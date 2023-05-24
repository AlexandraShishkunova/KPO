using Lab2;

namespace KPOLab2
{
    public class Program
    {
        public static void Main()
        {
            List<Flower> initialFlowers = new List<Flower>
            {
                new Orchid("Орхидея", 50.0, 30, "Фиолетовый"),
                new Lily("Лилия", 15.0, 40, "Свежий аромат"),
                new PottedFlower("Фикус", 25.0, 60),
                new CutFlower("Роза", 10.0, 50)
      };

            Bouquet bouquet = BouquetFactory.CreateBouquet(initialFlowers);

            bouquet.PrintBouquet();
            Console.WriteLine("Общая стоимость букета: " + bouquet.CalculateTotalPrice() + "\n");

            bouquet.ChangeFlowerPrice("Лилия", 7.0);
            bouquet.PrintBouquet();
            Console.WriteLine("Общая стоимость букета: " + bouquet.CalculateTotalPrice() + "\n");

            Console.ReadLine();


        }
    }
}
