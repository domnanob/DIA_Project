using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIA_Project.Forms;
using DIA_Project.Forms.TeacherForms;
using DIA_Project.Forms.UserForms;
using DIA_Project.Forms.AdminForms;
using DIA_Project.Forms.CommonForms;

namespace DIA_Project
{ 
    static class Program
    {
        public static string ConnectionString = "Server=localhost;Database=szakdoga;Uid=root;";
        public static AdminHomeForm AF;
        public static UserHomeForm HF;
        public static TeacherHomeForm TF;
        public static void FormLoader() {
            BejelentkezesForm BF = new BejelentkezesForm();
            BF.ShowDialog();
            if (BF.IsLoggedIn)
            {
                if (BF.CurrentUser.Username != null)
                {
                    if (BF.CurrentUser.RoleID == 1)
                    {
                        AF = new AdminHomeForm(BF.CurrentUser);
                        AF.ShowDialog();
                    }
                    else
                    {
                        HF = new UserHomeForm(BF.CurrentUser);
                        HF.ShowDialog();
                    }
                }
                else
                {
                    TF = new TeacherHomeForm(BF.CurrentTeacher);
                    TF.ShowDialog();
                }
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQL.ConnectionString = ConnectionString;
            FormLoader();
        }
    }
}
