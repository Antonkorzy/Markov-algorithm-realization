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

namespace НАМ
{
    public partial class CreateAlp : Form
    {
        public char[] mas;
        public bool flag = true;
        public CreateAlp()
        {
            InitializeComponent();
        }

        private void alph1_Click(object sender, EventArgs e) //бинарный алфавит
        {
            mas = new char[2];
            mas[0] = '0';
            mas[1] = '1';
            flag = true;
            Hide();
        }

        private void alph2_Click(object sender, EventArgs e) //Английский алфавит
        {
            mas = new char[53];
            int j = 0;
            for (char i = 'A'; i <= 'Z'; i++, j++)
            {
                mas[j] = i;
            }
            for (char i = 'a'; i <= 'z'; i++, j++)
            {
                mas[j] = i;
            }
            mas[52]= 'λ';
            flag = true;
            Hide();
        }

        private void alph3_Click(object sender, EventArgs e) //Русский алфавит
        {
            mas = new char[67];
            int j = 0;
            for (char i = 'А'; i <= 'Я'; i++, j++)
            {
                mas[j] = i;
            }
            for (char i = 'а'; i <= 'я'; i++, j++)
            {
                mas[j] = i;
            }
            mas[64] = 'ё';
            mas[65] = 'Ё';
            mas[66] = 'λ';
            flag = true;
            Hide();
        }

        private void alph_Click(object sender, EventArgs e)
        {
                string s = CreateMasText.Text;
                char[] bufMas = s.ToCharArray();             
                Array.Sort(bufMas); //сортировка для удобства
                bufMas = bufMas.Distinct().ToArray(); //избавление от пробелов лишних
            for (int i = 0; i < bufMas.Length; i++)
                if (bufMas[i] == ' ')
                    bufMas[i] = 'λ';
            mas = bufMas;
                flag = true;
            Hide();
        }

        private void buttonAlphCreate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);
                    string s = sr.ReadToEnd();
                    char[] bufMas = new char[s.Length];
                    for (int i = 0; i < s.Length; i++)
                        bufMas[i] = s[i];
                    Array.Sort(bufMas);
                    bufMas = bufMas.Distinct().ToArray();
                    for (int i = 0; i < bufMas.Length; i++)
                        if (bufMas[i] == ' ')
                            bufMas[i] = 'λ';
                    mas = bufMas;
                    flag = true;
                    Hide();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ваш алфавит был введён неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mas = null;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            flag = false;
        }

        private void CreateAlp_Load(object sender, EventArgs e)
        {
            textBoxEmpty.Text = "λ";
        }
    }
}
