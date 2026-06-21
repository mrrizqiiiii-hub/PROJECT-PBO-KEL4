using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Repository.Interface
{
    public interface IRepositoryTambah<T>
    {
        bool TambahData(T data);
    }
}
