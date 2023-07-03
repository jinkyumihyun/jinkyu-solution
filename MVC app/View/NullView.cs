using MVC_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_app.View
{
    internal class NullView : IView
    {
        public IEmployee? ShowView() { return null; }
    }
}
