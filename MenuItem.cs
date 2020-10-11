using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrfca_hw
{
   abstract class MenuItem
   {
        abstract public string Text { get; set; }
        abstract public void Execute();
        abstract public void Print();
   }
}
