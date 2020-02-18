using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Используя Visual Studio, создайте проект по шаблону WPF Application.
Создайте программу секундомер. Требуется выводить показания секундомера в окне. 
Окно имеет кнопки запуска, останова и сброса секундомера.
 */

namespace hm4
{
    public delegate void Mydelegate();
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       
    }
}
