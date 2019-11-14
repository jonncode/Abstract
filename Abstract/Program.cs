using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BodyParts> listOfParts = new List<BodyParts>();
            listOfParts.Add(new Lung());
            listOfParts.Add(new Heart("Hell"));
            listOfParts.Add(new Lung());
            foreach (BodyParts p in listOfParts)
            {
                p.CurrentBodyPart();
            }
            Console.ReadKey();
        }
    }
}
