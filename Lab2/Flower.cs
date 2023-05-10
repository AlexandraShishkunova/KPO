namespace KPOLab2
{
    public enum ColorsEnum
    {
        Red,
        Green,
        Blue
    }

    internal class Flower
    {
        public static int FlowersBought { get; private set; } //number of flowers bought

        public ColorsEnum Color;

        public readonly double Price;
        public readonly double WeightGrams;


        public Flower(ColorsEnum color)
        {
            Color = color;

            if (color == ColorsEnum.Red)
            {
                Price = 5;
                WeightGrams = 40.2;
            }
            else if (color == ColorsEnum.Green)
            {
                Price = 5.5;
                WeightGrams = 37.8;
            }
            else
            {
                Price = 4.7;
                WeightGrams = 41;
            }

            FlowersBought++;
        }
        public Flower()
        {
            // По умолчанию создается цвет Red
            Color = ColorsEnum.Red;
            Price = 5;
            WeightGrams = 40.2;

            FlowersBought++;
        }

        // Конструктор с указанием цвета, цены и веса
        public Flower(ColorsEnum color, double price, double weightGrams)
        {
            Color = color;
            Price = price;
            WeightGrams = weightGrams;

            FlowersBought++;
        }

     

        // Инициализатор для установки только цвета
        public void SetColor(ColorsEnum color)
        {
            Color = color;
        }

        public Flower(double price, double weightGrams)
        {
            Price = price;
            WeightGrams = weightGrams;
        }
        public Flower(Flower otherFlower) //конструктор копирования
            : this(otherFlower.Color, otherFlower.Price, otherFlower.WeightGrams) { }
        public void SetPriceAndWeight(double Price, double WeightGrams) //Блок инициализации для установки цены и веса в зависимости от цвета
        {
            if (Color == ColorsEnum.Red)
            {
                Price = 5;
                WeightGrams = 40.2;
            }
            else if (Color == ColorsEnum.Green)
            {
                Price = 5.5;
                WeightGrams = 37.8;
            }
            else
            {
                Price = 4.7;
                WeightGrams = 41;
            }




        }
    
        public void SetPriceAndWeightDefault(double Price, double WeightGrams) //Блок инициализации для установки цены и веса по умолчанию
        {
            Price = 5;
            WeightGrams = 40.2;
        }
    }
}
