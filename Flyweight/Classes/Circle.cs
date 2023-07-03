using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Interfaces;

namespace Flyweight.Classes
{
    public class Circle : IShape
    {
        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Radius = 30;
        public string Color { get; set; }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine($" Circle.Draw [Color: {Color}, X Cor: {XCor}, YCor: {YCor}, Radius: {Radius}]");
        }
    }
}
