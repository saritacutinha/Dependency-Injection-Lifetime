using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection_Lifetime.Models
{


    public interface ITransientService
    {
        Guid GetID();
    }

}
