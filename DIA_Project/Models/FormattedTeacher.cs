using System;

namespace DIA_Project.Models
{
    public class FormattedTeacher
    {
        public string Username { get; private set; }
        public string Name { get; private set; }
        public string Enabled { get; private set; }
        public DateTime LastLogon { get; private set; }
        public string Email { get; private set; }

        public FormattedTeacher(Teacher t)
        {
            Username = t.Username;
            Name = t.Name;
            Enabled = (t.Enable == 1) ? "Aktív" : "Tiltott";
            LastLogon = t.LastLogon;
            Email = t.Email;
        }
    }
}
