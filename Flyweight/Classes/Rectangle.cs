using Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes
{
    public class Rectangle : IShape
    {
        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Width = 30;
        private readonly int Height = 30;
        public string Color { get; set; }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine($" Rectangle.Draw [Color: {Color}, X Cor: {XCor}, YCor: {YCor}, Width: {Width}, Height: {Height}]");
        }
    }
}
