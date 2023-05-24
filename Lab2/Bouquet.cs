using KPOLab2;

    public class Bouquet
    {
        private List<Flower> flowers;

        public Bouquet()
        {
            flowers = new List<Flower>();
        }

        public Bouquet(List<Flower> initialFlowers)
        {
            flowers = new List<Flower>(initialFlowers);
        }

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public void RemoveFlower(Flower flower)
        {
            flowers.Remove(flower);
        }

        public void PrintBouquet()
        {
            Console.WriteLine("Состав букета:");
            foreach (Flower flower in flowers)
            {
            flower.PrintDetails();
            }
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (Flower flower in flowers)
            {
                totalPrice += flower.Price;
            }

            return totalPrice;
        }
        public void ChangeFlowerPrice(string flowerName, double newPrice)
        {
            foreach (Flower flower in flowers)
            {
                if (flower.Name == flowerName)
                {
                    flower.Price = newPrice;
                    break;
                }
            }
        }
    }
