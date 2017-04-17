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


        //стрипменю
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"       Вы уверенны, что хотите выйти?",
      "Lab #7", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,
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
      "Information Lab #7", MessageBoxButtons.OK, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //запаганил метод ниже, пусть будет, удалю
            if (N_tb.Text.Equals (""))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //TESTMDIParent1 s = new TESTMDIParent1();
                //s.Show();
                
            }

            else
            {
                //делаем все элементы вкладки "Терминалы" неактивными, кроме кнопки Перезагрузка

                leave_btn.Enabled = false;
                start_btn.Enabled = false;
                N_tb.Enabled = false;

                this.restart_btn.Enabled = true;
                Program.modeling = new Modeling(Convert.ToInt32(N_tb.Text));
                tabControl1.SelectTab(1);
                ActivateControls(1);
                //переход во вторую вкладку
                FillingDataGrid(dataGridView1);

            }
        }

        private void FillingDataGrid(DataGridView dgv)
        {
            for (int i = 1; i <= Program.modeling.N; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i - 1].Cells[0].Value = i.ToString();
            }
        }

        private bool IsFull(DataGridView dgv)
        {
            bool isfull = true;
            for (int j = 0; j < dgv.Rows.Count; j++)
                for (int i = 0; i < dgv.Rows[j].Cells.Count; i++)
                {
                    if (dgv.Rows[j].Cells[i].Value == null)
                        isfull = false;
                }
            return isfull;

        }

        double[] Tp;
        double[] dTp;

        double[] Tobr;
        double[] dtobr;

        private void SecondTab()
        {
          
            bool correct = true;
            if (IsFull(dataGridView1))
            {
                double result;
               Tp = new double[Program.modeling.N];
               dTp = new double[Program.modeling.N];

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
                    ActivateControls(2);
                    tabControl1.SelectTab(2);
                    FillingDataGrid(dataGridView2);
                }

            }

            else
            {
                MessageBox.Show("Заполните все ячейки.", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThirdTab()
        {
            bool correct = true;
            if (IsFull(dataGridView2))
            {
                double result;
                Tobr = new double[Program.modeling.N];
                dtobr = new double[Program.modeling.N];

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
                    ActivateControls(3);
                    tabControl1.SelectTab(3);

                    IsVisible();
                    IsVisible2();
                    sigma_tb.Enabled = false;
                    label4.Enabled = false;
                    input_rb.Checked = true;
                    input_dT_rb.Checked = true;
                }

              
            }

            else
            {
                MessageBox.Show("Заполните все ячейки.", "Ошибка заполнения ячеек таблицы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForthTab()
        {
            double result;
            uint res;

            if (!T_tb.Text.Equals("") && !K_tb.Text.Equals(""))
            {
                if (Double.TryParse(T_tb.Text, out result)&& uint.TryParse(K_tb.Text, out res))
                {
                    if (input_dT_rb.Checked)
                    {
                        if (!dT_tb.Text.Equals(""))
                        {
                            if (Double.TryParse(dT_tb.Text, out result))
                            {
                                //тоже
                                if (input_rb.Checked)
                                {
                                    if (!deltat_tb.Text.Equals(""))
                                    {
                                        if (Double.TryParse(deltat_tb.Text, out result))
                                        {

                                            //cтарт1
                                            Program.modeling.EnizializedForRun1(Convert.ToDouble(T_tb.Text), Convert.ToInt32(K_tb.Text), Convert.ToDouble(dT_tb.Text), Convert.ToDouble(deltat_tb.Text));
                                            ActivateControls(4);
                                            tabControl1.SelectTab(4);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (!sigma_tb.Text.Equals(""))
                                    {
                                        if (Double.TryParse(sigma_tb.Text, out result))
                                        {
                                            //старт2
                                            Program.modeling.EnizializedForRun2(Convert.ToDouble(T_tb.Text), Convert.ToInt32(K_tb.Text), Convert.ToDouble(dT_tb.Text), Convert.ToDouble(sigma_tb.Text));
                                            ActivateControls(4);
                                            tabControl1.SelectTab(4);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //тоже
                        if (input_rb.Checked)
                        {
                            if (!deltat_tb.Text.Equals(""))
                            {
                                if (Double.TryParse(deltat_tb.Text, out result))
                                {
                                    //cтарт3
                                    Program.modeling.EnizializedForRun3(Convert.ToDouble(T_tb.Text), Convert.ToInt32(K_tb.Text), Convert.ToDouble(deltat_tb.Text));
                                    ActivateControls(4);
                                    tabControl1.SelectTab(4);
                                }
                                else
                                {
                                    MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (!sigma_tb.Text.Equals(""))
                            {
                                if (Double.TryParse(sigma_tb.Text, out result))
                                {
                                    //старт4
                                    Program.modeling.EnizializedForRun4(Convert.ToDouble(T_tb.Text), Convert.ToInt32(K_tb.Text), Convert.ToDouble(sigma_tb.Text));
                                    ActivateControls(4);
                                    tabControl1.SelectTab(4);
                                }
                                else
                                {
                                    MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Некорректное введенное значение", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка заполнения полей ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tabControl1.SelectedIndex == 4)
            {
                for (int i = 0; i < Program.modeling.N; i++)
                {
                    comboBox1.Items.Add(i+1);
                }

                comboBox1.Items.Add("Показать все");
                
                //Program.modeling.GetInformation(this.dataGridView1,0);
                StartModelling(dataGridView3);
                comboBox1.SelectedIndex = Program.modeling.N;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ActivateControls(int i)
        {
            foreach (Control item in tabControl1.TabPages[i].Controls)
            {
                item.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            //this.Size = resolution;
            //this.tabControl1.Size = resolution;
            //this.StructuralScheme.Width = resolution.Width-20;
            //this.panel5.Width = resolution.Width-10;
            //this.panel5.Height = resolution.Height - 300 ;
            //this.StructuralScheme.Height = resolution.Height -300;
            //Point p = new Point();
            //p.X = StructuralScheme.Location.X+400;
            //p.Y = panel6.Location.Y;
            //this.panel6.Location = p;


            this.tabControl1.Size = this.Size;
            this.StructuralScheme.Width = this.Size.Width - 20;
            this.panel5.Width = this.Size.Width - 10;
            this.panel5.Height = this.Size.Height - 300;
            this.StructuralScheme.Height = this.Size.Height - 300;
            Point p = new Point();
            p.X = StructuralScheme.Location.X + 400;
            p.Y = panel6.Location.Y;
            this.panel6.Location = p;

            
            DeactivateControls();

        }

        private void DeactivateControls()
        {
            for (int i = 1; i < tabControl1.TabCount; i++)
            {
                foreach (Control item in tabControl1.TabPages[i].Controls)
                {
                    item.Enabled = false;
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void next_btn_1_Click(object sender, EventArgs e)
        {
            SecondTab();
        }

        private void next_btn_2_Click(object sender, EventArgs e)
        {
            ThirdTab();
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            ForthTab();
        }


        private void late_btn_1_Click(object sender, EventArgs e)
        {

        }

        private void late_btn_2_Click(object sender, EventArgs e)
        {

        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            DeactivateControls();
            ActivateControls(0);
            this.N_tb.Enabled = true;
            this.start_btn.Enabled = true;
            this.leave_btn.Enabled = true;
            ToNullPages();
            Program.modeling = null;
        }

        public void ToNullPages()
        {
            deltat_tb.Text = "";
            dT_tb.Text = "";
            K_tb.Text = "";
            N_tb.Text = "";
            sigma_tb.Text = "";
            T_tb.Text = "";

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            IsVisible();
            IsVisible2();
            sigma_tb.Enabled = false;
            label4.Enabled = false;
            input_rb.Checked = true;
            input_dT_rb.Checked = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            resolution.Width = resolution.Width / 2;

            this.MinimumSize = resolution;
            this.tabControl1.Size = this.Size;
            this.StructuralScheme.Width = this.Size.Width - 20;
            this.panel5.Width = this.Size.Width - 10;
            this.panel5.Height = this.Size.Height - 300;
            this.StructuralScheme.Height = this.Size.Height - 300;
            Point p = new Point();
            p.X = this.Size.Width/2-265 ;
            p.Y = panel6.Location.Y;
            this.panel6.Location = p;
            
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


       

        private void input_dT_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible2();
        }

        private void input_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible();
        }

        private void calc_dT_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible2();
        }

        private void calculate_rb_CheckedChanged(object sender, EventArgs e)
        {
            IsVisible();
        }
        public void StartModelling(DataGridView dgv)
        {

            foreach (Terminal t in Program.modeling.terminals)
            {
                t.CalculationOfTp();
            }
            double dt = Program.modeling.deltaT;
            while (Program.modeling.t <= Program.modeling.T)
            {

                if (Program.modeling.t >= dt)
                {
                    //Информация
                    Program.modeling.GetInformation(dgv, dt);
                    dt = dt + Program.modeling.deltaT;
                }

                Program.modeling.t = Program.modeling.t + Program.modeling.deltat;
                Program.modeling.ReceiptOfBids();
                

                if (Program.modeling.ISEmployed())
                {
                    Program.modeling.PackageTreatment();
                    Program.modeling.IsConflict();
                    Program.modeling.ReducingWindows();
                }
                else
                {
                    Program.modeling.Processing();
                    Program.modeling.ReducingWindows();
                }

            }
            //Program.modeling.GetInformation(this.dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();

            if (comboBox1.SelectedIndex<Program.modeling.N)
            {
                dataGridView4.Visible = true;
                for (int i = 0; i < Program.modeling.reserved[comboBox1.SelectedIndex].Count; i++)
                {
                    if (i == 0)
                    {
                        dataGridView4.Rows.Add(comboBox1.SelectedIndex + 1, Program.modeling.reserved[comboBox1.SelectedIndex][i].deltaT, Program.modeling.reserved[comboBox1.SelectedIndex][i].S, Program.modeling.reserved[comboBox1.SelectedIndex][i].Q, Program.modeling.reserved[comboBox1.SelectedIndex][i].R);
                    }
                    else
                    {
                        dataGridView4.Rows.Add("", Program.modeling.reserved[comboBox1.SelectedIndex][i].deltaT, Program.modeling.reserved[comboBox1.SelectedIndex][i].S, Program.modeling.reserved[comboBox1.SelectedIndex][i].Q, Program.modeling.reserved[comboBox1.SelectedIndex][i].R);
                    }
                }
            }
            else
            {
                dataGridView4.Visible = false;
            }

        }
    }
}
