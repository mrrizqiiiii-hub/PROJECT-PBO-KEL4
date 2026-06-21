using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Repository.Interface
{
    public interface IRepositoryBaca<T>
    {
        List<T> AmbilData();
    }
    
}
