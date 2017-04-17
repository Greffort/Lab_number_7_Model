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
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2  f2)
        {
            this.f2 = f2;
            InitializeComponent();
        }

        private bool IsFull()
        {
            bool isfull = true;
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
                for (int i = 0; i < dataGridView2.Rows[j].Cells.Count; i++)
                {
                    if (dataGridView2.Rows[j].Cells[i].Value == null)
                        isfull = false;
                }
            return isfull;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= Program.modeling.N; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i - 1].Cells[0].Value = i.ToString();
            }
        }

        private void late_btn_Click(object sender, EventArgs e)
        {
            this.f2.Visible = true;
            this.Close();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            bool correct = true;
            if (IsFull())
            {
                double result;
                double[] Tobr = new double[Program.modeling.N];
                double[] dtobr = new double[Program.modeling.N];

                for (int i = 0; i < Tobr.Length; i++)
                {
                    if (Double.TryParse(dataGridView2.Rows[i].Cells[1].Value.ToString(), out result))
                    {
                        Tobr[i] = Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correct = false;
                    }

                    if (Double.TryParse(dataGridView2.Rows[i].Cells[2].Value.ToString(), out result))
                    {
                        dtobr[i] = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        correct = false;
                    }
                }
                if (correct)
                {
                    Program.modeling.InitializationOfTobr(Tobr);
                    Program.modeling.InitializationOfdtobr(dtobr);



                    this.Visible = false;

                }

                Form4 f4 = new Form4(this);
                f4.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Заполните все ячейки.", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
