using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number_7_Model
{
    class Modeling
    {

        public List<Terminal> terminals;
        public double t { get; set; }
        public double deltat { get; set; }
        public double T { get; set; }
        public double deltaT { get; set; }
        public int N { get; set; }
        public int K { get; set; }
        public double ScalingFactor { get; set; }

        public Modeling(int N, double T,double deltaT, int K )
        {
            this.N = N;
            this.T = T;
            this.deltaT = deltaT;
            this.K = K;
            terminals = new List<Terminal>(this.N);
        }



        //инициализация среднего времени поступления
        public void InitializationOfTpost(double[] Tpost)
        {
            for (int i = 0; i < Tpost.Length; i++)
            {
                this.terminals[i].Tpost = Tpost[i];
            }
        }

        //инициализация вероятного отклонения времени поступления заявок
        public void InitializationOfdtpost(double[] dtpost)
        {
            for (int i = 0; i < dtpost.Length; i++)
            {
                this.terminals[i].dtpost = dtpost[i];
            }
        }

        //инициализация времени обработки
        public void InitializationOfTobr(double[] Tobr)
        {
            for (int i = 0; i < Tobr.Length; i++)
            {
                this.terminals[i].Tobr = Tobr[i];
            }
        }
        
        //инициализация вероятного отклонения времени обработки
        public void InitializationOfdtobr(double[] dtobr)
        {          
            for (int i = 0; i < dtobr.Length; i++)
            {
                this.terminals[i].dtobr = dtobr[i];
            }
        }

    }
}
