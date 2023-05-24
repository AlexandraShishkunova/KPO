namespace KPOLab2
{
    public abstract class Flower
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Flower(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void PrintDetails();
    }
}
