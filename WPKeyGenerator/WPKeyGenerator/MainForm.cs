using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WPKeyGenerator
{
    public partial class MainForm : Form
    {
        const string ASYMMETRIC = "Asymmetric";

        public MainForm()
        {
            InitializeComponent();
            pnlButtons.Enabled = false;
            statusLabel.Text = "Выберите тип ключа для продолжения работы";
        }

        private void btn_GenerateKey_Click(object sender, EventArgs e)
        {
            if (keyTypeSelected())
            {
                if (textBoxName.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Поле Name пустое. Нужно указать имя клиента для генерации ключа!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBoxKey.Text = keyGen.generateKey(textBoxName.Text.Trim());
                    statusLabel.Text = "Ключ сгенерирован";
                }
            }
        }

        private void btn_ValidateKey_Click(object sender, EventArgs e)
        {
            if (keyTypeSelected())
            {
                if (textBoxName.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Поле Name пустое. Нужно указать имя клиента для валидации ключа!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBoxKey.Text.Trim() == String.Empty)
                    {
                        MessageBox.Show("Поле Key пустое. Нужно указать ключ для его проверки!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (keyGen.validateKey(textBoxName.Text.Trim(), textBoxKey.Text.Trim()))
                        {
                            MessageBox.Show("Ключ валиден!!!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не верный ключ!!!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_SaveToFile_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string key = textBoxKey.Text.Trim();

            if(validData(name, key))
            {
                saveFileDialog1.Filter = "Key files|*.key|All files|*.*";
                saveFileDialog1.Title = "Save a Key File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != String.Empty)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, KeyGenerator.getDataForExport(name, key));
                    statusLabel.Text = "Ключ сохранен";
                }
            }
        }

        private void btn_CopyToClipboard_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string key = textBoxKey.Text.Trim();

            if(validData(name, key)){
                Clipboard.SetText(KeyGenerator.getDataForExport(name, key));
                statusLabel.Text = "Данные скопированы в буфер обмена";
            }
        }

        private Boolean validData(string name, string key)
        {
            Boolean res = false;
            if (keyTypeSelected())
            {
                if (textBoxName.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Поле Name пустое. Нужно указать имя клиента для экспорта ключа!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBoxKey.Text.Trim() == String.Empty)
                    {
                        MessageBox.Show("Поле Key пустое. Нужно указать ключ  для его экспорта!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!keyGen.validateKey(name, key))
                        {
                            MessageBox.Show("Не верный ключ!!! Экспорт запрещен!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        }
                        else
                        {
                            res = true;
                        }
                    }
                }
            }
            return res;
        }

        private Boolean keyTypeSelected()
        {
            if (comboBoxKeyType.Text == String.Empty)
            {
                MessageBox.Show("Укажите тип ключа!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxKeyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlButtons.Enabled = false;

            if (comboBoxKeyType.Text == ASYMMETRIC)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        keyGen = new KeyGeneratorAsymmetric(File.ReadAllText(openFileDialog1.FileName));

                        if ((keyGen as KeyGeneratorAsymmetric).publicOnly)
                            statusLabel.Text = "Загружен только публичный ключ! Генерация ключей не возможна";
                        else
                        {
                            statusLabel.Text = "Готово";
                            pnlButtons.Enabled = true;
                        }

                    }catch(Exception ex)
                    {
                        statusLabel.Text = String.Format("Не верный ключ: {0}", ex.Message);
                    }
                }
            }
            else
            {
                pnlButtons.Enabled = comboBoxKeyType.Text != String.Empty;
                keyGen = new KeyGeneratorHash();
                statusLabel.Text = "Готово";
            }
        }

        KeyGenerator keyGen;
    }
}
