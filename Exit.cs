using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrfca_hw
{
    class Exit : MenuItem
    {
        public override string Text { get; set; }

        public Exit()
        {
            this.Text = "[3] - Exit";
        }

        public override void Execute()
        {
            Console.WriteLine("See you later :)");
            Environment.Exit(0);
        }

        public override void Print()
        {
            Console.WriteLine(Text);
        }
    }
}
