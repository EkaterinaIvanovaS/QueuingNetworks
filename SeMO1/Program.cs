using System;
using System.Windows.Forms;

namespace SeMO1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// Данный проект создан для анализа характеристик виртуальных
        /// сетей массового обслуживания. Формулы для вычисления характеристик
        /// взяты из книги Ю. И. Митрофанова.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }
    }
}