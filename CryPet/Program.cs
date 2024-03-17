using CryPet.Windows.Authorized;
using CryPet.Windows.Main;
using CryPet.Windows.Registration;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CryPet
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizedForm());
        }
    }
}
