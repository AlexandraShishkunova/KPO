namespace KPOLab2
{
    public class FlowerFactory
    {
        public static Flower CreateFlower(string name, double price)
        {
            return new Flower(name, price);
        }
    }
}