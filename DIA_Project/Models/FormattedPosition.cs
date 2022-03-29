using System.Linq;

namespace DIA_Project.Models
{
    public class FormattedPosition
    {
        public string Class { get; set; }
        public string Subject { get; set; }

        public FormattedPosition(Position p)
        {
            SQL sql = SQL.MySql();
            Class = sql.classes.Single(x => x.ID == p.ClassID).Name;
            Subject = sql.subjects.Single(x => x.ID == p.SubjectID).Name;
        }
    }
}
