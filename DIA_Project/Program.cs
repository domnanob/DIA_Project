using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Forms;

namespace DIA_Project
{ 
    static class Program
    {
        public static string ConnectionString = "Server=localhost;Database=szakdoga;Uid=root;";
        public static HomeForm HF = new HomeForm(new Models.Users());
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQL.ConnectionString = Program.ConnectionString;
            BejelentkezesForm BF = new BejelentkezesForm();
            BF.ShowDialog();
            if (BF.IsLoggedIn)
            {
                if (BF.CurrentUser.Username != null)
                {
                    HF = new HomeForm(BF.CurrentUser);
                    Application.Run(HF);
                }
                else
                {
                    ErrorMessageForm emf = new ErrorMessageForm("A tanár felület még készítés alatt!");
                    emf.ShowDialog();
                }
            }
            
        }
    }
}
