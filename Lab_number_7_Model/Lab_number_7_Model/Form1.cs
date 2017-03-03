using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_number_7_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Form3 f3 = new Form3();
            f3.Show();
            Form4 f4 = new Form4();
            f4.Show();
            textBox5.Text = "111111111111111";
        }


        //стрипменю
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"       Вы уверенны, что хотите выйти?",
      "Lab #7 - Greffort", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Application.Exit();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        break;
                    }
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@" 
T - Модельное время
Δt - Приращение модельного времени
T - Время проведения исследования
ΔТ - Период отображения информации о состоянии системы
N - Количество терминалов
S[N] - Количество заявок, пришедших на терминал
Q[N] - Количество заявок в очереди терминала
R[N] - Количество обработанных заявок каждого терминала
F - Флаг занятости ЭВМ
P[N] - Наличие задержки у терминала
Tп[N] - Среднее время поступления заявок на терминал
Δtп[N] - Вероятное отклонение поступления заявки
tпост[N] - Время поступления заявки
ΔTобр[N] - Среднее время обработки заявки с терминала
Δtобр[N] - Вероятное отклонение обработки заявки с терминала
Tобр[N] - Время обработки заявки
K - Крайняя граница диапазона для выбора окна задержки
Tзад [N] - Время задержки
massindex[N] - Массив индексов терминалов, попавших в конфликт
RAND - Случайное число с плавающей точкой
RANDINT - Целое случайное число
",
      "Information Lab #7 - Greffort", MessageBoxButtons.OK, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
