using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НАМ
{
    public partial class Main : Form
    {
        public CreateAlp ca = new CreateAlp();
        public string[,] masTable = new string[0,4];
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Name = "img";
            img.HeaderText = "";
            img.ValuesAreIcons = true;
            EventTable.Columns.Insert(1, img);
            WorkStr.Enabled = false;
            buttonAddStr.Enabled = false;
            buttonDelStr.Enabled = false;
            buttonStart.Enabled = false;
            buttonStep.Enabled = false;
            textBoxEmpty.Text = "λ";
            toolStripButtonSave.Enabled = false;
        }

        #region Interface
        private void buttonCreateAlp_Click(object sender, EventArgs e)
        {
            ca.ShowDialog();
            if ((ca.mas != null) && (ca.flag))
            {
                labelAlp.Text = "Ваш алфавит: ";
                for (int i = 0; i < ca.mas.Length; i++)
                    labelAlp.Text += ca.mas[i];
                WorkStr.Enabled = true;
                WorkStr.Clear();
                EventTable.RowCount = 0;
                masTable = new string[0, 4];
                AddStr1(EventTable);
                buttonAddStr.Enabled = true;
                buttonDelStr.Enabled = true;
                buttonStart.Enabled = true;
                buttonStep.Enabled = true;
                labelStepBefore.ResetText();
                labelStrFirst.ResetText();
                textBoxTask.Clear();
            }                  
        }
        private void buttonAddStr_Click(object sender, EventArgs e)
        {
            AddStr1(EventTable);            
        }
        private void buttonDelStr_Click(object sender, EventArgs e)
        {
            if (EventTable.RowCount > 1)
            {
                EventTable.RowCount--;
                string[,] bufTable = new string[masTable.GetLength(0) - 1, 3];
                for (int i = 0; i < bufTable.GetLength(0); i++)
                    for (int j = 0; j < bufTable.GetLength(1); j++)
                        bufTable[i, j] = masTable[i, j];
                masTable = bufTable;
            }
        }
        private void AddStr1(DataGridView table)
        {
            table.RowCount++;
            table.Rows[table.RowCount - 1].HeaderCell.Value = (table.RowCount).ToString();
            int number_of_rows = table.RowCount;
            Icon image = Properties.Resources.direction;             
            table.Rows[number_of_rows - 1].Cells["img"].Value = image;
            table.Rows[number_of_rows - 1].Cells["img"].Tag = "direction";
            string[,] bufTable = new string[masTable.GetLength(0) + 1, 4];
            for (int i = 0; i < masTable.GetLength(0); i++)
                for (int j = 0; j < masTable.GetLength(1); j++)
                    bufTable[i, j] = masTable[i, j];
            masTable = bufTable;
            masTable[number_of_rows - 1, 1] = "direction";
        }
        private void EventTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if ((string)EventTable.Rows[e.RowIndex].Cells["img"].Tag == "direction")
                {
                    EventTable.Rows[e.RowIndex].Cells["img"].Value = Properties.Resources.arrow_dot;
                    EventTable.Rows[e.RowIndex].Cells["img"].Tag = "direction_dot";
                    masTable[e.RowIndex, e.ColumnIndex] = "direction_dot";
                }
                else
                {
                    EventTable.Rows[e.RowIndex].Cells["img"].Value = Properties.Resources.direction;
                    EventTable.Rows[e.RowIndex].Cells["img"].Tag = "direction";
                    masTable[e.RowIndex, e.ColumnIndex] = "direction";
                }
            }
        }
        #endregion

        #region Stroka
        public string mainStr = "";
        private bool _2=true;
        private void WorkStr_TextChanged(object sender, EventArgs e)
        {
                if (_2 == true)
                {

                TextBox btn = (TextBox)sender;
                string d = btn.Text;

                if (BelongToAlp(d,ca.mas))
                        mainStr = d;
                    else
                    {
                        _2 = false;
                    if (WorkStr.Text != "")
                        WorkStr.Text = mainStr;
                    else
                        mainStr = "";                     
                    }
                }
                else
                {
                    _2 = true;
                }
        }

        private bool BelongToAlp(string s, char[] ar)
        {
            bool flag = false;
            for (int i=0;i<s.Length;i++)
            {
                flag = false;
                for (int j=0; j<ar.Length;j++)
                {                   
                    if (s[i] == ar[j])
                        flag = true;
                }
                if (!flag)
                    return flag;
            }
            return flag;
        }


        #endregion

        #region CodeTable
        int posTableStep=0;
        bool NEVER = true;
        private void EventTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                try
                {
                    if (e.ColumnIndex == 2)
                    {
                        if (BelongToAlp((string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, ca.mas))
                        {
                            masTable[e.RowIndex, e.ColumnIndex] = (string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        }
                        else
                        {
                            if ((string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "λ")
                            {
                                masTable[e.RowIndex, e.ColumnIndex] = "";
                            }
                            else
                            {
                                if ((string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == "")
                                {
                                    EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "λ";
                                }
                                else
                                {
                                    MessageBox.Show("Данные введены неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        if (BelongToAlp((string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, ca.mas))
                        {
                            masTable[e.RowIndex, e.ColumnIndex] = (string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        }
                        else
                        {
                            MessageBox.Show("Данные введены неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Данные не введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                masTable[e.RowIndex, e.ColumnIndex] = (string)EventTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e) //в поле экземпляр запретить вводить пустоту
        {
            labelStrFirst.Text = "Исходная строка: " + mainStr;                   
            bool flag = true;
            for (int i = 0; i < masTable.GetLength(0); i++)
            {
                for (int j = 0; j < masTable.GetLength(1) - 1; j++)
                {
                    if (masTable[i, j] == null)
                        flag = false;
                    if (masTable[i, j] == "")
                        EventTable.Rows[i].Cells[j].Value = "λ";
                }
            }

            if (flag)
            {
                try
                {
                    int posTable = 0;
                    if (mainStr != "")
                    {
                        int circle = 0;
                        int OldPosTable;
                        do
                        {
                            circle++;
                            OldPosTable = posTable;
                            int index = mainStr.IndexOf(masTable[posTable, 0]);
                            if (index != -1)
                            {
                                mainStr = mainStr.Remove(index, masTable[posTable,0].Length);
                                mainStr = mainStr.Insert(index, masTable[posTable, 2]);
                                posTable = 0;
                            }
                            else
                            {
                                posTable++;
                            }
                        } while ( (posTable < masTable.GetLength(0)) && (masTable[OldPosTable, 1] != "direction_dot") && (circle<10000) );
                        if (circle >= 10000)
                            MessageBox.Show("Ваш алгоритм зациклился или произошло переполнение!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            WorkStr.Text = mainStr;
                            MessageBox.Show("Работа алгоритма завершена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сначала введите слово в рабочую строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Пожалуйста, заполните все ячейки с командами или удалите не нужные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все ячейки с командами или удалите не нужные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (NEVER)
            {
                labelStrFirst.Text = "Исходная строка: " + mainStr;
                NEVER = false;
            }
            string lsb = labelStepBefore.Text;
            labelStepBefore.Text = "Строка на предыдущем шаге: " + mainStr;
            bool flag = true;
            int oldPosTableStep;
            for (int i = 0; i < masTable.GetLength(0); i++)
            {
                for (int j = 0; j < masTable.GetLength(1) - 1; j++)
                {
                    if (masTable[i, j] == null) 
                        flag = false;
                    if (masTable[i, j] == "")
                        EventTable.Rows[i].Cells[j].Value = "λ";
                }
            }
            if (flag)
            {
                try
                {
                    if (mainStr != "")
                    {
                        bool exit = false;
                        do
                        {
                            int index = mainStr.IndexOf(masTable[posTableStep, 0]);
                            oldPosTableStep = posTableStep;
                            if (index != -1)
                            {
                                mainStr = mainStr.Remove(index, masTable[posTableStep, 0].Length);
                                mainStr = mainStr.Insert(index, masTable[posTableStep, 2]);
                                EventTable.Rows[posTableStep].Selected = true;
                                posTableStep = 0;
                                exit = true;
                            }
                            else
                            {
                                posTableStep++;
                            }
                        } while (!exit && posTableStep < masTable.GetLength(0));
                            WorkStr.Text = mainStr;                      
                        if ((masTable[oldPosTableStep, 1] == "direction_dot") || (posTableStep > masTable.GetLength(0)-1))
                        {
                            MessageBox.Show("Работа алгоритма завершена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            posTableStep = 0;
                            labelStrFirst.Text = "Исходная строка: " + mainStr;
                            labelStepBefore.Text = "";
                            NEVER = true;
                        }
                        
                    }
                    else
                    {
                        if (lsb == "")
                        {
                            MessageBox.Show("Сначала введите слово в рабочую строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            labelStepBefore.Text = "";
                        }
                        else
                        {
                            string[] tr = lsb.Split(':');
                            tr[tr.Length - 1] = tr[tr.Length - 1].Remove(0, 1);
                            bool end = false;
                            for (int i1 = 0; i1 < masTable.GetLength(0); i1++)
                                if ((masTable[i1, 0] == tr[tr.Length - 1]) && (masTable[i1, 2] == ""))
                                    end = true;
                            if (end)
                            {
                                MessageBox.Show("Работа алгоритма завершена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                posTableStep = 0;
                                labelStrFirst.Text = "Исходная строка: " + mainStr;
                                labelStepBefore.Text = "";
                                NEVER = true;
                            }
                            else
                            {
                                MessageBox.Show("Сначала введите слово в рабочую строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                labelStepBefore.Text = "";
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Пожалуйста, заполните все ячейки с командами или удалите не нужные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelStepBefore.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все ячейки с командами или удалите не нужные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelStepBefore.Text = "";
            }
        }
        private bool CellBelongToAlp(string s, char[] ar)
        {
            bool flag = false;
            char[] bufAr = new char[ar.Length + 1];
            for (int i = 0; i < ar.Length; i++)
            {
                bufAr[i] = ar[i];
            }
            bufAr[bufAr.Length - 1] = 'λ';
            ar = bufAr;         
            for (int i = 0; i < s.Length; i++)
            {
                flag = false;
                for (int j = 0; j < ar.Length; j++)
                {
                    if (s[i] == ar[j])
                        flag = true;
                }
                if (!flag)
                    return flag;
            }
            return flag;
        }
 
        #endregion

        #region file
        string path;
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "bin files (*.bin)|*.bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WriteRead wr = new WriteRead();
                path = sfd.FileName;
                masTable = new string[0, 4];
                string[,] bufMasTable = wr.OpenFile(path);
                labelAlp.Text = "Ваш алфавит: ";
                EventTable.RowCount = 0;           
                EventTable.ColumnCount = bufMasTable.GetLength(1);
                for (int i = 0; i < bufMasTable.GetLength(0)-1; i++)
                {
                    AddStr1(EventTable);
                    for (int j = 0; j < bufMasTable.GetLength(1); j++)
                    {
                        masTable[i, j] = bufMasTable[i, j];
                        if (j != 1)
                        {
                            EventTable.Rows[i].Cells[j].Value = masTable[i, j];
                        }
                        else
                        {
                            if (masTable[i, j] == "direction_dot")
                            {
                                EventTable.Rows[i].Cells[j].Value = Properties.Resources.arrow_dot;
                            }
                        }
                    }
                }
                toolStripButtonSave.Enabled = true;
                ca.mas = new char[bufMasTable[bufMasTable.GetLength(0) - 1, 2].Length];
                for (int i = 0; i < ca.mas.GetLength(0); i++)
                {
                    ca.mas[i] = bufMasTable[bufMasTable.GetLength(0) - 1, 2][i];
                    labelAlp.Text += ca.mas[i];
                }
                textBoxTask.Text = bufMasTable[bufMasTable.GetLength(0) - 1, 0];
                mainStr= bufMasTable[bufMasTable.GetLength(0) - 1, 1];
                WorkStr.Text = mainStr;
                WorkStr.Enabled = true;
                buttonStart.Enabled = true;
                buttonStep.Enabled = true;
                buttonAddStr.Enabled = true;
                buttonDelStr.Enabled = true;
                labelStepBefore.Text = "";
                labelStrFirst.Text = "Исходная строка:";
            }
            
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                WriteRead wr = new WriteRead();
                string[,] bufMasTable = new string[masTable.GetLength(0) + 1, masTable.GetLength(1)];
                for (int i = 0; i < masTable.GetLength(0); i++)
                    for (int j = 0; j < masTable.GetLength(1); j++)
                    {
                        bufMasTable[i, j] = masTable[i, j];
                    }
                bufMasTable[masTable.GetLength(0), 0] = textBoxTask.Text;  //условие
                bufMasTable[masTable.GetLength(0), 1] = mainStr; //рабочая строка
                for (int i = 0; i < ca.mas.Length; i++)  //алфавит
                    bufMasTable[masTable.GetLength(0), 2] += ca.mas[i];
                wr.CreateFile(bufMasTable, path);
            }
            else
                MessageBox.Show("Сначала откройте файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripButtonSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "bin files (*.bin)|*.bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WriteRead wr = new WriteRead();
                path = sfd.FileName;
                string[,] bufMasTable = new string[masTable.GetLength(0)+1, masTable.GetLength(1)];
                for (int i=0; i<masTable.GetLength(0);i++)
                    for(int j=0; j<masTable.GetLength(1);j++)
                    {
                        bufMasTable[i, j] = masTable[i, j];
                    }
                bufMasTable[bufMasTable.GetLength(0)-1, 0] = textBoxTask.Text;  //условие
                bufMasTable[bufMasTable.GetLength(0)-1, 1] = mainStr; //рабочая строка
                for (int i = 0; i < ca.mas.Length; i++)  //алфавит
                    bufMasTable[masTable.GetLength(0), 2] += ca.mas[i];
                wr.CreateFile(bufMasTable, path);
            }
        }
        #endregion


    }
}
