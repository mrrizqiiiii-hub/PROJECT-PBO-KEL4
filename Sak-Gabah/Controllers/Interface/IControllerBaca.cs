using System;
using System.Collections.Generic;
using System.Text;

namespace Sak_Gabah.Controllers.Interface
{
    public interface IControllerBaca<T>
    {
        List<T> AmbilData();
    }
    
}
