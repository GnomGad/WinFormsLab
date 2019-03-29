using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsLab
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
            
            
        }

        public static void Build()
        {
            
            StartMenu Menu = new StartMenu();
            
            if (!Menu.ExistAuthorizationBinaryFile(WinFormsLab.Constants.FileAutorizarion_dat))
                Menu.CreateAuthorizationBinaryFile(WinFormsLab.Constants.FileAutorizarion_dat);

        }
    }
}
