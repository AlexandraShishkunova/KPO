using Lab2;

namespace KPOLab2
{
    public class Program
    {
        public static void Main()
        {
            List<Flower> initialFlowers = new List<Flower>
      {
        FlowerFactory.CreateFlower("Роза", 10.0),
        FlowerFactory.CreateFlower("Тюльпан", 5.0),
        FlowerFactory.CreateFlower("Лилия", 8.0)
      };

            Bouquet bouquet = BouquetFactory.CreateBouquet(initialFlowers);

            bouquet.PrintBouquet();
            Console.WriteLine("Общая стоимость букета: " + bouquet.CalculateTotalPrice() + "\n");

            bouquet.ChangeFlowerPrice("Тюльпан", 7.0);
            bouquet.PrintBouquet();
            Console.WriteLine("Общая стоимость букета: " + bouquet.CalculateTotalPrice() + "\n");

            Console.ReadLine();


        }
    }
}
