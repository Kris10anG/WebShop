using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class StoreInventory
    {
        public List<GameItem> InventoryList { get; set; }
        public StoreInventory()
        {
            InventoryList = new List<GameItem>();
            InventoryList.Add(new PUBG(1, "PUBG",150));
            InventoryList.Add(new PokemonLetsGoEvee(2, "PokemonLetsGoEvee", 250));
            InventoryList.Add(new CyberPunk(3, "CyberPunk", 400));
            InventoryList.Add(new BattleField(4, "BattleField", 100));
        }

        public List<GameItem> ListPhysicalItems()
        {
            var buyphysicallist = InventoryList.Where(game => game is IBuyPhysical).ToList();
            return buyphysicallist;
        }


        public List<GameItem> ListDownLoadable()
        {
            var buydownloadablegame = InventoryList.Where(game => game is IDownLoadable).ToList();
            return buydownloadablegame;
        }

        public void HandleCommand()
        {
            // Skal lese inn input fra brukere her
            // Inventory skal printe ut informasjon basert på valget brukeren tok. 
            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == gameID);
            ShoppingCart.Add(gameToBuy);
            //Sjekk på om spillet skal shippes eller lastes ned
            //Print ut med Download eller shipping metoden under
        }
        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }
        }
    }
}
