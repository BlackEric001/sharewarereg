using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPKeyGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_GenerateKey_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Поле Name пустое. Нужно указать имя клиента для генерации ключа!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBoxKey.Text = KeyGenerator.generateKey(textBoxName.Text.Trim());
            }
        }

        private void btn_ValidateKey_Click(object sender, EventArgs e)
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
                   if(KeyGenerator.validateKey(textBoxName.Text.Trim(), textBoxKey.Text.Trim()))
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
                }
            }
        }

        private void btn_CopyToClipboard_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string key = textBoxKey.Text.Trim();

            if(validData(name, key)){
                Clipboard.SetText(KeyGenerator.getDataForExport(name, key));
            }
        }

        private Boolean validData(string name, string key)
        {

            Boolean res = false;
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
                    if (!KeyGenerator.validateKey(name, key))
                    {
                        MessageBox.Show("Не верный ключ!!! Экспорт запрещен!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                    else
                    {
                        res = true;
                    }
                }
            }
            return res;
        }
    }
}
