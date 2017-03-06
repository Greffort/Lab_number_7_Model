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
    public partial class Form4 : Form
    {
        Form3 f3;
        public Form4()
        {
            InitializeComponent();
        }

        private void IsVisible()
        {
            if (input_rb.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        public Form4(Form3 f3)
        {
            this.f3 = f3;
            InitializeComponent();
        }

        private void calculate_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible();
        }

        private void input_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible();
        }

        private void late_btn_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            IsVisible();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (input_rb.Checked == true)
            {
                if (!textBox1.Text.Equals(""))
                {
                    double result;
                    if (Double.TryParse(textBox1.Text, out result))
                    {
                        Program.modeling.deltat = Convert.ToDouble(textBox1.Text);
                       

                    }
                    else
                    {
                        MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения поля для ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка заполнения поля для ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Visible = false;
                Form5 f5 = new Form5(this);
                f5.Show();
                //Program.modeling.deltat = Program.modeling.CalculationOfIncrementModelTime
            }
        }
        
    }
}
