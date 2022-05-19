using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Helfrich
{
    public class Desk
    {
        public string firstName;
        public string lastName;
        public string dateNow;
        public string totalPrice;
        public int width;
        public int depth;
        public int drawers;
        public string material;
        public string rushOrder;

        public Desk(string firstName, string lastName, string dateNow, string totalPrice, int width, int depth, int drawers, string material, string rushOrder)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateNow = dateNow;
            this.totalPrice = totalPrice;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
            this.rushOrder = rushOrder;
        }
    }
}
