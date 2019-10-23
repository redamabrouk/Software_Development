using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    // The Target defines the domain-specific interface used by the client code.

    public interface ITarget
    {
        string GetRequest();
    }
}
