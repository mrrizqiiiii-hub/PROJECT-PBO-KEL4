using Sak_Gabah.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Helpers
{
    public static class UserSession
    {
        public static M_user userAktif { get; set; }
        public static void ClearSession()
        {
            userAktif = null;
        }
    }
}
