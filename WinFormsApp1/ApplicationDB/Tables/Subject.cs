using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Tables
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual User User { get; set; }
        [ForeignKey("SubjectId")]
        public virtual List<Lesson> Lessons { get; set; }
    }
}
