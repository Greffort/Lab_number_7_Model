using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int F { get; set; }
        public int k { get; set; }

        public int[] massindex;

        public Modeling(int N, double T, double deltaT, int K)
        {
            this.N = N;
            this.T = T;
            this.deltaT = deltaT;
            this.K = K;
            this.F = 0;
            terminals = new List<Terminal>(this.N);

            for (int i = 0; i < N; i++)
            {
                terminals.Add(new Terminal());
            }
           
            
            this.t = 0;
            this.massindex = new int[N];
            for (int i = 0; i < N; i++)
            {
                massindex[i] = -1;

            }
           
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

        //инициализация S,Q,R,P
        public void SQRPInitialization()
        {
            for (int i = 0; i < this.N; i++)
            {
                this.terminals[i].S = 0;
                this.terminals[i].Q = 0;
                this.terminals[i].R = 0;
                this.terminals[i].P = 0;

            }
        }

        //рассчет дельта-t
        public void CalculationOfIncrementModelTime(ProgressBar pr)
        {
            pr.Maximum = this.N;
            double minimum = this.terminals[0].Tpost - this.terminals[0].dtpost;
            for (int i = 0; i < N; i++)
            {
                if (minimum > this.terminals[i].Tpost - this.terminals[i].dtpost)
                    minimum = this.terminals[i].Tpost - this.terminals[i].dtpost;

                if (minimum > this.terminals[i].Tobr - this.terminals[i].dtobr)
                    minimum = this.terminals[i].Tobr - this.terminals[i].dtobr;

                this.deltat = minimum * this.ScalingFactor;
                pr.Value++;
            }

        }

        //проверка на конец
        public bool IsFinish()
        {
            if (this.t >= this.T) return true;
            else return false;
        }

        //вывод информации о состоянии системы
        public string ReturnInformation()
        {
            string s = "";
            return s;
        }

        //поступление заявок
        public void ReceiptOfBids()
        {
            for (int i = 0; i < N; i++)
            {
                if (terminals[i].tp <= 0)
                {
                    terminals[i].S++;
                    terminals[i].Q++;
                }
            }
        }

        //проверка на занятость ЦЭВМ
        public bool ISEmployed()
        {
            if (this.F > 0) return true;
            else return false;
        }

        //продвижение обработки
        public void Processing()
        {
            if (terminals[F].to <= 0)
            {
                terminals[F].R++;
                terminals[F].Q--;
                F = 0;
            }
        }

        //уменьшение окон задержки
        public void ReducingWindows()
        {
            for (int i = 0; i < k; i++)
            {
                if (terminals[i].P > 0) terminals[i].P--;
            }
        }

        //формирование пакетов на обработку
        public void PackageTreatment()
        {
            this.k = 0;

            for (int i = 0; i < N; i++)
            {
                if (terminals[i].P < 1)
                {
                    if (terminals[i].Q > 0)
                    {
                        k = k + 1;
                        this.massindex[k] = i;
                    }
                }

            }
        }

        public void IsConflict()
        {
            Random rand = new Random();
            if (this.k > 0)
            {
                if (k > 1)
                {
                    for (int i = 0; i < k; i++)
                    {
                        terminals[massindex[i]].P = rand.Next(1, K);
                        massindex[i] = -1;
                    }
                }
                else { F = this.massindex[0]; terminals[F].CalculationOfto(); }
            }

        }


    }
    //запуск процесса моделирования


}

