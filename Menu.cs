using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrfca_hw
{
    class Menu
    {
       private List<MenuItem> menu = new List<MenuItem>()
            {
                new ChangeColor(),
                new Help(),
                new Exit()

            };
        public Menu() { }
        public void DrowMenu()
        {
            foreach(var item in menu)
            {
                item.Print();
            }
        }

        public void startAction()
        {
            int numb = 0;
            while (true)
            {
                DrowMenu();
                Console.Write("Enter number: ");
                numb = int.Parse(Console.ReadLine());
                Console.Clear();
                Choice(numb);
            }
        }
        public void Choice(int numb)
        {
            if(numb<= 1 || numb > 3)
            {
                 Console.WriteLine("\nUse numbers from 1 to 3\n");
                return;
            }
            else
            {
                var el = menu[numb - 1];
                el.Execute();
            }     
        }

    }
    
}
