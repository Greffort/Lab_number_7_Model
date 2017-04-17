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
                deltat_tb.Enabled = true;
                sigma_tb.Enabled = false;
                label2.Enabled = false;
            }
            else
            {
                deltat_tb.Enabled = false;
                sigma_tb.Enabled = true;
                label2.Enabled = true;
            }
        }

        private void IsVisible2()
        {
            if (input_dT_rb.Checked)
            {
                dT_tb.Enabled = true;
            }
            else
            {
                dT_tb.Enabled = false;
            }
        }

        public Form4(Form3 f3)
        {
            this.f3 = f3;
            InitializeComponent();
        }


    

        private void late_btn_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            IsVisible();
            IsVisible2();
            sigma_tb.Enabled = false;
            label2.Enabled = false;
            input_rb.Checked = true;
            input_dT_rb.Checked = true;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (input_rb.Checked == true)
            {
                if (!deltat_tb.Text.Equals(""))
                {
                    double result;
                    if (Double.TryParse(deltat_tb.Text, out result))
                    {
                        Program.modeling.deltat = Convert.ToDouble(deltat_tb.Text);

                        if (T_tb.Text.Equals("") || dT_tb.Text.Equals("") || K_tb.Text.Equals(""))
                        {
                            MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            if (Double.TryParse(T_tb.Text, out result) && Double.TryParse(dT_tb.Text, out result) && Double.TryParse(K_tb.Text, out result))
                            {
                                Program.modeling.ToEnizializedModeling(Convert.ToDouble(T_tb.Text), Convert.ToDouble(dT_tb.Text), Convert.ToInt32(K_tb.Text));
                                Program.modeling.control();

                                this.Visible = false;
                                ProcessForm pf = new ProcessForm();
                                pf.Show();
                            }

                            else
                            {
                                MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения поля для ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

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
                if (T_tb.Text.Equals("") || dT_tb.Text.Equals("") || K_tb.Text.Equals(""))
                {
                    MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    double result;
                    if (Double.TryParse(T_tb.Text, out result) && Double.TryParse(dT_tb.Text, out result) && Double.TryParse(K_tb.Text, out result))
                    {
                        Program.modeling.ToEnizializedModeling(Convert.ToDouble(T_tb.Text), Convert.ToDouble(dT_tb.Text), Convert.ToInt32(K_tb.Text));
                        this.Visible = false;
                        Form5 f5 = new Form5(this);
                        f5.Show();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля.", "Ошибка заполнения поля для ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (calc_dT_rb.Checked == true)
                {
                    Program.modeling.CalculationOfIncrementdT();
                }
                //Program.modeling.deltat = Program.modeling.CalculationOfIncrementModelTime
            }
        }

        private void input_dT_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible2();
        }

        private void calc_dT_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible2();
        }


        private void calculate_rb_CheckedChanged_1(object sender, EventArgs e)
        {
            IsVisible();
        }

        private void input_rb_CheckedChanged_1(object sender, EventArgs e)
        {
            IsVisible();
        }
    }
}
