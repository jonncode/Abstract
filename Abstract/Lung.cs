using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Lung : BodyParts
    {
        public override void CurrentBodyPart()
        {
            Console.WriteLine("The current body part is the lung, the body naturally has two of these.");
        }
    }
}
