using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Sak_Gabah.Models;
using Sak_Gabah.Helpers;
using Sak_Gabah.Repository;

namespace Sak_Gabah.Controllers
{
    public class C_authLogin
    {
        private R_authLogin repo = new R_authLogin();

        public M_user AuthLogin(string username, string password)
        {
            return repo.AuthLogin(username, password);
        }

        public bool RegistrasiUserBaru(M_user userBaru)
        {
            if (repo.cekUsername(userBaru.username))
            {
                return false;
            }

            if (repo.cekEmail(userBaru.email))
            {
                return false;
            }

            return repo.RegistrasiUserBaru(userBaru);
        }

    }
}
