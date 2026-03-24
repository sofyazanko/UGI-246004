using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class User
    {
        readonly string login;
        public string Login
        {
            get => login; 
        }
        public User(string userLogin)
        {
            foreach (var ch in login)
                if (!char.IsLetterOrDigit(ch))
                    throw new ArgumentException($"{login}:логин должен содержать только из буквы и цифры");
                else
                    this.login = userLogin;
            Logger.LogInfo($"Пользователь {login} создан");
        }
        ~User()
        {
            Logger.LogInfo($"Пользователь {login} удален из памяти");
        }
        public string GetInfo() => $"Пользователь {Login}";
    }
}
    