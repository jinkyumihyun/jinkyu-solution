using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class School
    {
        private readonly List<IElement> _elements;
        private readonly List<IVisitor> _visitors;     
        private School(List<IElement> elements, List<IVisitor> visitors)
            => (_elements, _visitors) = (elements, visitors);
        public static School Create(List<IElement> elements, List<IVisitor> visitors)
        => (elements, visitors) switch
        {
            (null, _) => throw new ArgumentNullException(nameof(elements)),
            (_, null) => throw new ArgumentNullException(nameof(visitors)),
            (_, _) => new School(elements, visitors)
        };
        public void PerformOperations() => _visitors.ForEach(vis => _elements.ForEach(el => Visiting(vis, el)));
        private void Visiting(IVisitor vis, IElement el)
        {
            if (el is IExtElement ExtEl)
            {
                ExtEl.Accept((IExtVisitor)vis); //overloading
            }
            else
            {
                el.Accept(vis);
            }
        }
    }
}
