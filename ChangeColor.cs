using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrfca_hw
{
    class ChangeColor : MenuItem
    {
        public override string Text { get; set; }

        public ChangeColor()
        {
            this.Text = "[1] - Change Menu Color";
        }
        public override void Execute()
        {
            Console.Write("Enter color: ");
            string tColor = Console.ReadLine();
            ConsoleColor customColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), tColor);
            Console.ForegroundColor = customColor;
        }

        public override void Print()
        {
            Console.WriteLine(Text);
        }
    }
}
