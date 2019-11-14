using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Heart : BodyParts
    {
        public Heart(string area) : base(area)
        {

        }
        public override void CurrentBodyPart()
        {
            Console.WriteLine("The current body part is the Heart, this boy pumps out liters of blood a minute");
        }
    }
}
