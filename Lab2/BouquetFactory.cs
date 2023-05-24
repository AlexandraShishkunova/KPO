using KPOLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class BouquetFactory
    {
        public static Bouquet CreateBouquet(List<Flower> initialFlowers)
        {
            Bouquet bouquet = new Bouquet();
            foreach (Flower flower in initialFlowers)
            {
                bouquet.AddFlower(flower);
            }
            return bouquet;
        }
    }
}
