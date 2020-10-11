using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrfca_hw
{
    class Help : MenuItem
    {
        public override string Text { get; set; }

        public Help()
        {
            this.Text = "[2] - Help";
        }
        public override void Execute()
        {
            Console.WriteLine("\nTry to use number: 1,2,3\n");
        }

        public override void Print()
        {
            Console.WriteLine(Text);
        }
    }
}
