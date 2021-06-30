using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetE4
{
    public class Admin
    {
        private string _login;
        private string _mdp;

        public string Login { get => _login; private set => _login = value; }
        public string Mdp { get => _mdp; private set => _mdp = value; }


        public Admin(string login, string mdp)
        {
            Login = login;
            Mdp = mdp;
        }

        public Admin()
        { }
    }
}
