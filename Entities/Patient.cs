using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class Patient
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Todo: Cinsiyet Düzelecek
         public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SecurityQuestion { get; set; }
        public string  Answer { get; set; }
        public string Password { get; set; }

    }
}
