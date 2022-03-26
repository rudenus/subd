using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Tables
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Class Class { get; set; }  
        public virtual Role Role { get; set; }
        [ForeignKey("UserId")]
        public virtual List<Lesson> Lessons { get; set; }
    }
}
