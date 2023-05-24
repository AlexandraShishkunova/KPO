using KPOLab2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    public class PottedFlower : Flower
    {
        public int Height { get; set; }

        public PottedFlower(string name, double price, int height) : base(name, price)
        {
            Height = height;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Цветок в горшке: {Name}, Высота: {Height} см, Цена: {Price}");
        }
    }

    public class Orchid : PottedFlower
    {
        public string Color { get; set; }
        public Orchid(string name, double price, int height, string color) : base(name, price, height)
        {
            Color = color;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Цветок в горшке: {Name}, Высота: {Height} см, Цвет: {Color}, Цена: {Price}");
        }
    }


    }
