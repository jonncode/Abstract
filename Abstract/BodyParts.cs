using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class BodyParts
    {
        public BodyParts()
        {
            Console.WriteLine("A body part was discovered");
        }
        public BodyParts(string area) : base()
        {
            Console.WriteLine("Body part was located in " + area);
        }
        public abstract void CurrentBodyPart();
    }
}
