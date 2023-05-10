namespace KPOLab2
{
    internal class FlowerShop
    {
        public FlowerShop()
        {
            // Конструктор по умолчанию
        }

        public FlowerShop(params Flower[] flowers)
        {
            // Конструктор с параметрами
        }

        // Блок инициализации
        static FlowerShop()
        {
            // Инициализация статических членов класса
        }

        // Конструктор-копирование
        public FlowerShop(FlowerShop other)
        {
            // Копирование состояния из другого объекта FlowerShop
        }

        public Bouquet MakeBouquet(Flower[] flowers)
        {
            if (flowers == null) throw new ArgumentException("Flowers array is null!");



            return new Bouquet(flowers);
        }

        public Flower BuyFlower(ColorsEnum color)
        {
            return new Flower(color);
        }

        public Bouquet BuyBouquet(ColorsEnum[] colors)
        {
            if (colors == null) throw new ArgumentException("Colors array is null!");


            var flowers = new List<Flower>();
            foreach (var color in colors)
            {
                flowers.Add(new Flower(color));
            }

            return new Bouquet(flowers.ToArray());
        }
    }

}

