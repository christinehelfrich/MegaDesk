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
        public int width;
        public int depth;
        public int drawers;
        public string material;

        public Desk(string firstName, string lastName, int width, int depth, int drawers, string material)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
        }
    }
}
