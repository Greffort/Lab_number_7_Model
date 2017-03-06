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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsFull()
        {
            bool isfull = true;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
                for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                        isfull = false;
                }
            return isfull;

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            bool correct = true;
            if (IsFull())
            {
                double result;
                double[] Tp = new double[Program.modeling.N];
                double[] dTp = new double[Program.modeling.N];

                for (int i = 0; i < Tp.Length; i++)
                {
                    if (Double.TryParse(dataGridView1.Rows[i].Cells[1].Value.ToString(), out result))
                    {
                        Tp[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correct = false;
                    }

                    if (Double.TryParse(dataGridView1.Rows[i].Cells[2].Value.ToString(), out result))
                    {
                        dTp[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correct = false;
                    }
                }
                if (correct)
                {
                    Program.modeling.InitializationOfTpost(Tp);
                    Program.modeling.InitializationOfdtpost(dTp);
                   
                    Form3 f3 = new Form3(this);

                    this.Visible = false;
                    f3.Show();
                }


            }

            else
            {
                MessageBox.Show("Заполните все ячейки.", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= Program.modeling.N; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i - 1].Cells[0].Value = i.ToString();
            }

        }
    }
}
