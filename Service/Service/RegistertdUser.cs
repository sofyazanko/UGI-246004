using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class RegistertdUser : User
    {
        public string Email;
        private string password;

        public RegistertdUser (string login, string password, string email):base (login)
        {
           
            Email=email;

            if (password.Length<8) {
        }
    }
}
