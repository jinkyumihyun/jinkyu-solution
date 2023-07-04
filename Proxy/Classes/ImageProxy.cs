using HelperLib;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    public class RealImage : IImage
    {
        public string Filename { get; set; }
        public RealImage(string? filename)
        {
            Filename = Helper.IsNullWhite(filename) ?? throw new ArgumentException(nameof(filename));
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading Image : {Filename}");
        }
        public void DisplayImage()
        {
            Console.WriteLine($"Displaying Image : {Filename}");
        }
    }

    public class ProxyImage : IImage
    {
        private RealImage? realImage = null;

        private readonly object _lock = new object();

        private string _fileName;
        public string Filename
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = Helper.IsNullWhite(value) ?? throw new ArgumentException(value); ;
                    realImage = null;
                }
            }
        }
        public ProxyImage(string? filename)
        {
            Filename = Helper.IsNullWhite(filename) ?? throw new ArgumentException(nameof(filename));
        }
        public void DisplayImage()
        {
            if (realImage == null)
            {
                lock (_lock)
                {
                    if (realImage == null)
                    {
                        realImage = new RealImage(Filename);
                    }
                }
            }

            realImage.DisplayImage();
        }
    }

}
