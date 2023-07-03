using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Interfaces
{
    public interface ITV
    {
        string Size { get; set; }
        string Price { get; set; }
        bool USBSupport { get; set; }
        ITV Clone();
        string GetDetails();
    }
}
