using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    sealed public class ImmediateDrawAttribute :Attribute
    {
    }
}
