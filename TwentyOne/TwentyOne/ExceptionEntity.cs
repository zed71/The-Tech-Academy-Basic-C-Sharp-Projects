using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //entity is refers to a db object, each property in this class maps to a column in the db Exceptions tbl.
    public class ExceptionEntity
    {
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
