using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Finger : BodyParts
    {
        public override void CurrentBodyPart()
        {
            Console.WriteLine("The current body part is the finger, the human body has 10 of these.");
        }
    }
}
