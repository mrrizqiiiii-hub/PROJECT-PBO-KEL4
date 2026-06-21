

using Sak_Gabah.Models;
using Sak_Gabah.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers
{
    internal class C_kelolaAkun 
    {
        private R_kelolaAkun repo = new R_kelolaAkun();
        private R_authLogin repoAuth= new R_authLogin();
        public List<M_user> AmbilData()
        {
            return repo.AmbilData();
        }

        public List<M_user> AmbilData(string keyWord)
        {
            return repo.AmbilData(keyWord);
        }

        public M_user AmbilData(int id)
        {
            return repo.AmbilData(id);
        }

        public bool editAkunKaryawan(M_user dataUser)
        {
            return repo.editAkunKaryawan(dataUser);
        }

        public bool TambahData(M_user dataBaru)
        {

            if (repo.cekDuplikat(dataBaru))
            {
                return false;
            }
            
            return repo.TambahData(dataBaru);
        }

        public bool resetPassword(string username)
        {
            return repo.resetPassword(username);
        }

        public bool gantiPassword(string username, string passwordlama, string passwordbaru)
        {
            if (repo.cekPassword(username, passwordlama))
            {
                return repo.gantiPassword(username, passwordbaru);
            }

            return false;
        }

        public int tambahCustomer(string nama, string noTelpon, string alamat)
        {
            return repo.tambahCustomer(nama, noTelpon, alamat);
        }

        public bool updateAkun(M_user dataUser, string username)
        {
            

            if (repoAuth.cekUsername(username))
            {
                return false;
            }

            return repo.updateAkun(dataUser);
        }


    }
}

