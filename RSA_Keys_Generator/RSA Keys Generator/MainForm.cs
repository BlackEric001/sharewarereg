using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace RSATest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Генерилка RSA ключей (3072)";
            toolStripStatusLabel1.Text = "Ready to work!";
            textBox1.ReadOnly = true;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsp = new RSACryptoServiceProvider(3072);
            //rsp.FromXmlString();
            //RSAParameters rsaKeyInfo = rsp.ExportParameters(true);
            //textBox1.Text = rsaKeyInfo.ToString();
            //rsaKeyInfo.
            textBox1.Text = rsp.ToXmlString(true);
         //   rsp.
        }*/

        private void GenerateKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rsp = new RSACryptoServiceProvider(3072);
            textBox1.Text = rsp.ToXmlString(true);
            toolStripStatusLabel1.Text = String.Format("Был сгенерен ключ с алгоритмом {0}", rsp.SignatureAlgorithm);
        }

        private void SavePrivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rsp.ToXmlString(true));
                toolStripStatusLabel1.Text = String.Format("Приватный ключ был сохранен в {0}", saveFileDialog1.FileName);
            }
        }

        private void SavePublicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rsp.ToXmlString(false));
                toolStripStatusLabel1.Text = String.Format("Публичный ключ был сохранен в {0}", saveFileDialog1.FileName);
            }
        }

        private void LoadKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            try
            {

                string str = File.ReadAllText(openFileDialog1.FileName);
                DisposeProvider();
                rsp = new RSACryptoServiceProvider();
                rsp.FromXmlString(str);
                if (rsp.PublicOnly)
                {
                    textBox1.Text = rsp.ToXmlString(false);
                    toolStripStatusLabel1.Text = "Загружен публичный ключ";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Загружен приватный ключ";
                    textBox1.Text = rsp.ToXmlString(true);
                }
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = String.Format("Ошибка при загрузке файла ключа: {0}", ex.Message);
            }
        }

        RSACryptoServiceProvider rsp; // = new RSACryptoServiceProvider(3072);

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeProvider();
        }

        private void DisposeProvider()
        {
            if (rsp != null)
                rsp.Dispose();
        }
    }
}
