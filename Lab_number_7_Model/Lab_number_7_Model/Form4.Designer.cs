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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.late_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculate_rb = new System.Windows.Forms.RadioButton();
            this.input_rb = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приращение модельного времени (Δt):";
            // 
            // late_btn
            // 
            this.late_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.late_btn.Location = new System.Drawing.Point(43, 114);
            this.late_btn.Name = "late_btn";
            this.late_btn.Size = new System.Drawing.Size(140, 20);
            this.late_btn.TabIndex = 3;
            this.late_btn.Text = "Назад";
            this.late_btn.UseVisualStyleBackColor = true;
            this.late_btn.Click += new System.EventHandler(this.late_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next_btn.Location = new System.Drawing.Point(200, 114);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(122, 20);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calculate_rb);
            this.panel2.Controls.Add(this.input_rb);
            this.panel2.Location = new System.Drawing.Point(43, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 48);
            this.panel2.TabIndex = 18;
            // 
            // calculate_rb
            // 
            this.calculate_rb.AutoSize = true;
            this.calculate_rb.Location = new System.Drawing.Point(11, 26);
            this.calculate_rb.Name = "calculate_rb";
            this.calculate_rb.Size = new System.Drawing.Size(195, 17);
            this.calculate_rb.TabIndex = 0;
            this.calculate_rb.TabStop = true;
            this.calculate_rb.Text = "Расчитать время моделирования";
            this.calculate_rb.UseVisualStyleBackColor = true;
            this.calculate_rb.CheckedChanged += new System.EventHandler(this.calculate_rb_CheckedChanged);
            // 
            // input_rb
            // 
            this.input_rb.AutoSize = true;
            this.input_rb.Location = new System.Drawing.Point(11, 3);
            this.input_rb.Name = "input_rb";
            this.input_rb.Size = new System.Drawing.Size(179, 17);
            this.input_rb.TabIndex = 1;
            this.input_rb.TabStop = true;
            this.input_rb.Text = "Задать время моделирования";
            this.input_rb.UseVisualStyleBackColor = true;
            this.input_rb.CheckedChanged += new System.EventHandler(this.input_rb_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 159);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.late_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(366, 110);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button late_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton calculate_rb;
        private System.Windows.Forms.RadioButton input_rb;
    }
}