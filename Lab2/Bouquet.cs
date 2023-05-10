using KPOLab2;

internal class Bouquet
{
    public static int BouquetsMade { get; private set; } // number of bouquets made
    public Flower[] Flowers { get; private set; }

    public double WeightGrams
    {
        get
        {
            var weight = 0d;
            foreach (var flower in Flowers)
            {
                weight += flower.WeightGrams;
            }
            return weight;
        }
    }

    public double Price
    {
        get
        {
            var price = 0d;
            foreach (var flower in Flowers)
            {
                price += flower.Price;
            }
            return price;
        }
    }

    public Flower TheCheapestFlower
    {
        get
        {
            var theCheapestFlower = Flowers[0];
            foreach (var flower in Flowers)
            {
                if (flower.Price < theCheapestFlower.Price)
                    theCheapestFlower = flower;
            }
            return theCheapestFlower;
        }
    }

    public Flower TheMostExpensiveFlower
    {
        get
        {
            var theMostExpensiveFlower = Flowers[0];
            foreach (var flower in Flowers)
            {
                if (flower.Price > theMostExpensiveFlower.Price)
                    theMostExpensiveFlower = flower;
            }
            return theMostExpensiveFlower;
        }
    }

    public Bouquet(Flower[] flowers) //конструктор, кот принимает массив объектов Flower и присваивает его полю Flowers класса Bouquet
    {
        if (flowers == null)
            throw new ArgumentException("Flowers array is null!");

        Flowers = flowers;

        BouquetsMade++;
    }

    public Bouquet(double[] flowerPrices, double[] flowerWeights) //конструктор с параметрами
    {
        if (flowerPrices.Length != flowerWeights.Length) throw new ArgumentException("Flower prices and weights arrays have different lengths!");

        Flowers = new Flower[flowerPrices.Length];

        for (int i = 0; i < flowerPrices.Length; i++)
        {
            Flowers[i] = new Flower(flowerPrices[i], flowerWeights[i]);
        }

        BouquetsMade++;
    }

    public Bouquet() //конструктор по умолчанию
    {
        Flowers = new Flower[0];
        BouquetsMade++;
    }

    static Bouquet() //блок инициализации
    {
        BouquetsMade = 0;
    }

    public Bouquet(Bouquet otherBouquet) //конструктор копирования
    {
        Flowers = new Flower[otherBouquet.Flowers.Length];

        for (int i = 0; i < otherBouquet.Flowers.Length; i++)
        {
            Flowers[i] = new Flower(otherBouquet.Flowers[i].Price, otherBouquet.Flowers[i].WeightGrams);
        }

        BouquetsMade++;
    }


}
