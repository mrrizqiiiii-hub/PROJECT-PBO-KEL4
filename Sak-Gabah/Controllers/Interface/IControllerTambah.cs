using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers.Interface
{
    public interface IControllerTambah<T>
    {
        bool TambahData(T data);
    }
}
