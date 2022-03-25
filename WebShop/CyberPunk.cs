using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class CyberPunk : GameItem, IDownLoadable, IBuyPhysical
    {
        public CyberPunk(int id, string name, int price) : base(id, name, price)
        {
        }
    }
}
