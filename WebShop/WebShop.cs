using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class WebShop
    {
        public WebShop()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games")

                HandleCommand();
            }
        }
    }
}
