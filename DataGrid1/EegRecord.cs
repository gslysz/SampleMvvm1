using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid1
{
    public class EegRecord
    {

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public bool IsSelected { get; set; }
    }
}
