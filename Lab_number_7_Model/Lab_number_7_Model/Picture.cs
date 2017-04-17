using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab_number_7_Model
{
    public partial class Picture : Form
    {
        public Picture()
        {
            InitializeComponent();
            timer1.Start();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.AllowTransparency = true;
            //this.BackColor = Color.AliceBlue;//цвет фона  
            //this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //Thread.Sleep(1);
            //timer1.Stop();
            this.Opacity += 0.2;

            if (this.Opacity == 1) { timer1.Stop(); }
        }

        private void Picture_Load(object sender, EventArgs e)
        {

        }
    }
}
