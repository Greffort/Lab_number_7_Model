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
    public partial class ProcessForm : Form
    {
        Form5 f5;

        public ProcessForm (Form5 f5)
        {
            this.f5 = f5;
            InitializeComponent();
        }
        public ProcessForm()
        {
            InitializeComponent();
            //int N = 5;
            //Program.modeling = new Modeling(N);
            //int ntp = N + 7;
            //int nto = N;
            //double[] Tp = new double[N];
            //double[] dtp = new double[N];
            //double[] Tobr = new double[N];
            //double[] dtobr = new double[N];

            //for (int i = 0; i < N; i++)
            //{
            //    Tp[i] = ntp;
            //    dtp[i] = ntp - 5;


            //    Tobr[i] = nto;
            //    dtobr[i] = nto - 3;


            //}

            //Program.modeling.InitializationOfTpost(Tp);
            //Program.modeling.InitializationOfTobr(Tobr);
            //Program.modeling.InitializationOfdtobr(dtobr);
            //Program.modeling.InitializationOfdtpost(dtp);

            //Program.modeling.ToEnizializedModeling(5000, 5, 1);
            //Program.modeling.deltat = 1;



        }
        public void StartModelling()
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
                    Program.modeling.GetInformation(this.dataGridView1,dt);
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



        private void ProcessForm_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            Program.modeling.GetInformation(this.dataGridView1, 0);
            this.StartModelling();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 //Program.modeling.GetInformation(this.dataGridView1);
 //           this.StartModelling();
        }
    }
}
