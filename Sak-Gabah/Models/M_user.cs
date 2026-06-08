using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Models
{
    public class M_user : M_basePerson
    {
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string namaLengkap { get; set; }
        public string noTelp { get; set; }
        public string role { get; set; }
        public string statusAkun { get; set; }
        public int id_kabupaten { get; set; }
        public M_kabupaten kabupaten { get; set; } = new M_kabupaten();
    }
}
