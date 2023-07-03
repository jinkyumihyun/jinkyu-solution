using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Classes;
using Flyweight.Interfaces;

namespace Flyweight.Classes
{
    public class ShapeFactory
    {
        private static Dictionary<Type, IShape> s_shapeMap = new Dictionary<Type, IShape>();
        public static IShape GetShape(Type shapeType)
        {
            IShape? shape = null;
            if (! s_shapeMap.TryGetValue(shapeType, out shape))
            {
                Console.WriteLine($"CREATES a shape for {shapeType}");
                object? classInstance = Activator.CreateInstance(shapeType, null);
                shape = classInstance as IShape;
                if (shape != null)
                {
                    Console.WriteLine($"SAVES the shape for {shapeType}");
                    s_shapeMap.Add(shapeType, shape);
                } 
                else
                {
                    Console.WriteLine($"NOT saved.");
                }
            }
            else
            {
                Console.WriteLine($"RETRIEVES a shape for {shapeType} from storage");
            }
            return shape ?? NullShape.GetInstance();
        }
    }
}

