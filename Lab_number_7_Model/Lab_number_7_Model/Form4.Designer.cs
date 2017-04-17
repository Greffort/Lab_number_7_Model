namespace Lab_number_7_Model
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deltat_tb = new System.Windows.Forms.TextBox();
            this.late_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T_tb = new System.Windows.Forms.TextBox();
            this.K_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dT_tb = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calc_dT_rb = new System.Windows.Forms.RadioButton();
            this.input_dT_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sigma_tb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.calculate_rb = new System.Windows.Forms.RadioButton();
            this.input_rb = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // deltat_tb
            // 
            this.deltat_tb.Location = new System.Drawing.Point(6, 35);
            this.deltat_tb.Name = "deltat_tb";
            this.deltat_tb.Size = new System.Drawing.Size(105, 20);
            this.deltat_tb.TabIndex = 1;
            // 
            // late_btn
            // 
            this.late_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.late_btn.Location = new System.Drawing.Point(22, 340);
            this.late_btn.Name = "late_btn";
            this.late_btn.Size = new System.Drawing.Size(216, 37);
            this.late_btn.TabIndex = 3;
            this.late_btn.Text = "Назад";
            this.late_btn.UseVisualStyleBackColor = true;
            this.late_btn.Click += new System.EventHandler(this.late_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn.Location = new System.Drawing.Point(273, 340);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(216, 37);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.T_tb);
            this.panel1.Controls.Add(this.K_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 70);
            this.panel1.TabIndex = 19;
            // 
            // T_tb
            // 
            this.T_tb.Location = new System.Drawing.Point(11, 11);
            this.T_tb.Name = "T_tb";
            this.T_tb.Size = new System.Drawing.Size(100, 20);
            this.T_tb.TabIndex = 2;
            // 
            // K_tb
            // 
            this.K_tb.Location = new System.Drawing.Point(11, 37);
            this.K_tb.Name = "K_tb";
            this.K_tb.Size = new System.Drawing.Size(100, 20);
            this.K_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время проведения исследования (Т)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Максимальное количество окон задержки (K)";
            // 
            // dT_tb
            // 
            this.dT_tb.Location = new System.Drawing.Point(6, 32);
            this.dT_tb.Name = "dT_tb";
            this.dT_tb.Size = new System.Drawing.Size(104, 20);
            this.dT_tb.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.calc_dT_rb);
            this.panel3.Controls.Add(this.input_dT_rb);
            this.panel3.Location = new System.Drawing.Point(121, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 48);
            this.panel3.TabIndex = 20;
            // 
            // calc_dT_rb
            // 
            this.calc_dT_rb.AutoSize = true;
            this.calc_dT_rb.Location = new System.Drawing.Point(11, 25);
            this.calc_dT_rb.Name = "calc_dT_rb";
            this.calc_dT_rb.Size = new System.Drawing.Size(80, 17);
            this.calc_dT_rb.TabIndex = 0;
            this.calc_dT_rb.TabStop = true;
            this.calc_dT_rb.Text = "Расчитать ";
            this.calc_dT_rb.UseVisualStyleBackColor = true;
            this.calc_dT_rb.CheckedChanged += new System.EventHandler(this.calc_dT_rb_CheckedChanged);
            // 
            // input_dT_rb
            // 
            this.input_dT_rb.AutoSize = true;
            this.input_dT_rb.Location = new System.Drawing.Point(11, 3);
            this.input_dT_rb.Name = "input_dT_rb";
            this.input_dT_rb.Size = new System.Drawing.Size(64, 17);
            this.input_dT_rb.TabIndex = 1;
            this.input_dT_rb.TabStop = true;
            this.input_dT_rb.Text = "Задать ";
            this.input_dT_rb.UseVisualStyleBackColor = true;
            this.input_dT_rb.CheckedChanged += new System.EventHandler(this.input_dT_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dT_tb);
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 87);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время вывода информации ΔТ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sigma_tb);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.deltat_tb);
            this.groupBox2.Location = new System.Drawing.Point(23, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 122);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приращение модельного времени Δt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Точность σ";
            // 
            // sigma_tb
            // 
            this.sigma_tb.Location = new System.Drawing.Point(6, 83);
            this.sigma_tb.Name = "sigma_tb";
            this.sigma_tb.Size = new System.Drawing.Size(105, 20);
            this.sigma_tb.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.calculate_rb);
            this.panel4.Controls.Add(this.input_rb);
            this.panel4.Location = new System.Drawing.Point(121, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 48);
            this.panel4.TabIndex = 20;
            // 
            // calculate_rb
            // 
            this.calculate_rb.AutoSize = true;
            this.calculate_rb.Location = new System.Drawing.Point(11, 25);
            this.calculate_rb.Name = "calculate_rb";
            this.calculate_rb.Size = new System.Drawing.Size(80, 17);
            this.calculate_rb.TabIndex = 0;
            this.calculate_rb.TabStop = true;
            this.calculate_rb.Text = "Расчитать ";
            this.calculate_rb.UseVisualStyleBackColor = true;
            this.calculate_rb.CheckedChanged += new System.EventHandler(this.calculate_rb_CheckedChanged_1);
            // 
            // input_rb
            // 
            this.input_rb.AutoSize = true;
            this.input_rb.Location = new System.Drawing.Point(11, 3);
            this.input_rb.Name = "input_rb";
            this.input_rb.Size = new System.Drawing.Size(64, 17);
            this.input_rb.TabIndex = 1;
            this.input_rb.TabStop = true;
            this.input_rb.Text = "Задать ";
            this.input_rb.UseVisualStyleBackColor = true;
            this.input_rb.CheckedChanged += new System.EventHandler(this.input_rb_CheckedChanged_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.late_btn);
            this.MinimumSize = new System.Drawing.Size(366, 110);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox deltat_tb;
        private System.Windows.Forms.Button late_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox T_tb;
        private System.Windows.Forms.TextBox dT_tb;
        private System.Windows.Forms.TextBox K_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton calc_dT_rb;
        private System.Windows.Forms.RadioButton input_dT_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton calculate_rb;
        private System.Windows.Forms.RadioButton input_rb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sigma_tb;
    }
}