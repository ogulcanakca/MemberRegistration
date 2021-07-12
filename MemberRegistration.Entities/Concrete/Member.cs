using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELibrary.Library.Core.Entities;


namespace MemberRegistration.Entities.Concrete
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TcNo { get; set; } // TC 'ye işlem yapılmayacak -çarpılma, toplama vs. sabittir- bu yüzden string 
        public string Email { get; set; }
    }
}
