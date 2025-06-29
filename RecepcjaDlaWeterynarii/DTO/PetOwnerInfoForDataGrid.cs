using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepcjaDlaWeterynarii.DTO
{
    public class PetOwnerInfoForDataGrid
    {
        public string PetName { get; set; }
        public string Species { get; set; }
        public int MicrochipNumber { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public PetOwnerInfoForDataGrid(string petName, string species, int microchipNumber, string ownerName, string address, string phoneNumber)
        {
            PetName = petName;
            Species = species;
            MicrochipNumber = microchipNumber;
            OwnerName = ownerName;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
