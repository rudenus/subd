using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Tables
{
    public class Class
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Letter { get; set; }
        [ForeignKey("ClassId")]
        public virtual List<User> Users { get; set; }
    }
}
