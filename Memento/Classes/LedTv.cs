using HelperLib;
using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class LEDTV : ITV
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        private LEDTV(string Size, string Price, bool USBSupport) =>
            (this.Size, this.Price, this.USBSupport) = (Size, Price, USBSupport);
        public static ITV Create(string Size, string Price, bool USBSupport)
        => (Helper.IsNullWhite(Size), Helper.IsNullWhite(Price)) switch
        {
           (null, _) => throw new ArgumentException(nameof(Size)),
           (_, null) => throw new ArgumentException(nameof(Price)),
           (_, _) => new LEDTV(Size, Price, USBSupport)
        };
        public ITV Clone() => (ITV)this.MemberwiseClone();
        public string GetDetails() => $"LEDTV [Size = {Size}; Price = {Price}; USBSupport = {USBSupport}]";
    }
}
