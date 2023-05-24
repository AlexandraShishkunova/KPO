using KPOLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CutFlower : Flower
    {
        public int StemLength { get; set; }

        public CutFlower(string name, double price, int stemLength) : base(name, price)
        {
            StemLength = stemLength;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Срезанный цветок: {Name}, Длина: {StemLength} см, Цена: {Price}");
        }
    }


    public class Lily : CutFlower
    {
        public string Fragrance { get; set; }
        public Lily(string name, double price, int stemLength, string fragrance) : base(name, price, stemLength)
        {
            Fragrance = fragrance;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Срезанный цветок: {Name}, Длина стебля: {StemLength} см, Аромат: {Fragrance}, Цена: {Price}");
        }
    }

    }