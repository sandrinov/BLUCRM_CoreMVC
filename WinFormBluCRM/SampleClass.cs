using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBluCRM
{
    public class SampleClass
    {
        public delegate void ItsRainingEventHandler(object o, double mb);

        public event ItsRainingEventHandler ItsRaining;
    }
}
