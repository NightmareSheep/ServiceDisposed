using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfDen.Services
{
    public interface IAccountService
    {
        void DeleteInactiveUserData();
    }
}
