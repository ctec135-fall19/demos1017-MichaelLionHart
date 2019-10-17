using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbstractBaseClass  // tells modifier it can't instantiate anything in this class
    {
        public abstract int AbstractMethod(int num);  // no code, just a statement, parameters, and a semicolon
    }
}
