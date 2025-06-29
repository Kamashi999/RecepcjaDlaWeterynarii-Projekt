using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepcjaDlaWeterynarii.Tables
{
    public class Visits
    {
        public int VisitId { get; set; }
        public int OwnerId { get; set; }
        public int PetId { get; set; }
        public string Reason { get; set; }
    }
}
