using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_number_7_Model
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public static Modeling modeling;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
# region Работа с PictureForm
            Picture first = new Picture();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(0);
            first.Show();

            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            #endregion

            //вызов первой формы
            //Application.Run(new Form1());
            Application.Run(new HelloMenuForm());
        }
    }
}
