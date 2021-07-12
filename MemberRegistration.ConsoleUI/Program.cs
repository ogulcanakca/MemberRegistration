using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependecyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Alican",
                LastName = "Akca",
                DateOfBirth = new DateTime(2001, 7, 27),
                TcNo = "27898039646",
                Email = "alicanakca_2016@hotmail.com"
                
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
