using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIGADIC_COURSE.Classes
{
    public class Register
    {
        public int ID { get; set; }
        public string? TCKN { get; set; }
        public string? NAME { get; set; }
        public string? SURNAME { get; set; }
        public string? COURSE { get; set; }
        public DateTime REGISTERDATE { get; set; }
        public string? STATUS { get; set; }
        public bool GENDER { get; set; }
        public string? PHONE { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public int COURSEID { get; set; }
        public int TRAINEEID { get; set; }
        public int COUNT { get; set; }
        public string? GENDERDESC { get; set; }
        public string? STATUSDESC { get; set; }
    }
}
