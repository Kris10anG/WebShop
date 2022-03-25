using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class PokemonLetsGoEvee : GameItem, IBuyPhysical
    {
        public PokemonLetsGoEvee(int id, string name, int price) : base(id, name, price)
        {
        }
    }
}
