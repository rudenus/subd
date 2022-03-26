using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Tables
{
    public class Lesson
    {
        public int Id { get; set; }
        public int Estimation { get; set; }
        public DateTime date { get; set; }
        public virtual User User { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
