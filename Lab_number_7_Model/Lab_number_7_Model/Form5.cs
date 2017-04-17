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
    public partial class Form5 : Form
    {
        Form4 f4;
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(Form4 f4)
        {
            this.f4 = f4;
            InitializeComponent();
        }

        private void IsFull()
        {
            if (textBox1.Text.Equals(""))
            {
                next_btn.Enabled = false;
            }
            else next_btn.Enabled = true;
        }
        private void next_btn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                double result;
                if (Double.TryParse(textBox1.Text,  out result))
                {
                    Program.modeling.ScalingFactor = Double.Parse(textBox1.Text);
                    Program.modeling.CalculationOfIncrementModelTime();
                    this.Visible = false;
                    ProcessForm pf = new ProcessForm(this);
                    pf.Show();


                }
                else
                {
                    MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения поля для ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void late_btn_Click(object sender, EventArgs e)
        {
            f4.Visible = true;
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            IsFull();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            IsFull();
        }
    }
}
