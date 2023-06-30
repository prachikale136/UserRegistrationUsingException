using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        public static void Main(string[] args) 
        {

            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Prachi");
            validateUser.validateLastName("KAle");
            validateUser.validateEmailId("prachi@gmail.com");
            validateUser.validateMobileNumber("9563214627");
            validateUser.validatePassword("prachii012");
            Console.ReadKey();
        }
    }
}