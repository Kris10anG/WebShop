using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class GameItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }

        public GameItem(int id, string name, int price)
        {
            Id = id;
            GameName = name;
            Price = price;
        }
        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
