using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class School
    {
        private readonly List<IElement> _elements;
        private readonly List<IVisitor> _visitors;     
        private School(List<IElement> elements, List<IVisitor> visitors)
            => (_elements, _visitors) = (elements, visitors);    
        public void PerformOperations() => _visitors.ForEach(vis => _elements.ForEach(el => el.Accept(vis)));
        public static School Create(List<IElement> elements, List<IVisitor> visitors)
          => (elements, visitors) switch
          {
              (null, _) => throw new ArgumentNullException(nameof(elements)),
              (_, null) => throw new ArgumentNullException(nameof(visitors)),
              (_, _) => new School(elements, visitors)
          };
    }
   
}
