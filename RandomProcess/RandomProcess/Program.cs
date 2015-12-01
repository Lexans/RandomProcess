using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProcess
{
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
            Application.Run(new FormSelectMethod());
        }

        public static void ShowHelp() {
            try
            {
                Process.Start("Help.html");
            }
            catch (Exception e)
            {
                MessageBox.Show("Отсутствует файл справки", "Ошибка при открытии справки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
