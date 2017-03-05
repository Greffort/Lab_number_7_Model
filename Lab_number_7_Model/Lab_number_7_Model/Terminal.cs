using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number_7_Model
{
    class Terminal
    {
        public int S;
        public int Q;
        public int R;

        public int P;

        public double Tpost;
        public double dtpost;
        public double tp;

        public double Tobr { set; get; }
        public double dtobr { set; get; }
        public double to;

        public int[] massindex;


        public void CalculationOfTp()
        {
            Random rand = new Random();
            this.tp = (this.Tpost - this.dtpost) + 2 * this.dtpost * rand.NextDouble();
        }


        public void CalculationOfto()
        {
            Random rand = new Random();
            this.to = (this.Tobr - this.dtobr) + 2 * this.dtobr *rand.NextDouble();
        }




    }
}
