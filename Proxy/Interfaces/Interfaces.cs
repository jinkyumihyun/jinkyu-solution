using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    public interface IImage
    {
        string Filename { get; set; }
        void DisplayImage();
    }
    public interface IText
    {
        string Filename { get; set; }
        void DisplayText();
    }

    public interface IServer
    {
        void Operate();
        public string ServiceName { get; set;}
        public void Operate(string serviceName);
    }

    public interface IService
    {
        void Operate();
    }
}
