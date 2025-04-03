using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    public class WrongEntering : Exception
    {
        public WrongEntering(string message) : base(message) { }
    }
}
