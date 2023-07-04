using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Classes;
using Proxy.Interfaces;

namespace Proxy.Classes
{
    class ProxyServer : IServer
    {
        public ProxyServer(string serviceName)
            => _serviceName = serviceName;

        IService? _service = null;
        string _serviceName;
        public string ServiceName
        {
            get =>_serviceName; 
            set 
            { 
                _serviceName = value;
                _service = null; 
            }
        }

        private readonly object _serviceLock = new object();

        public void Operate()
        {
            if (_service == null)
            {
                lock (_serviceLock)
                {
                    if (_service == null)
                    {
                        _service = ServiceFactory.Create(_serviceName); 
                    }
                }
            }
            
            _service.Operate();          
        }
        public void Operate(string serviceName)
        {
            ServiceName = serviceName;

            if (_service == null)
            {
                lock (_serviceLock)
                {
                    if (_service == null)
                    {
                        _service = ServiceFactory.Create(serviceName);
                    }
                }
            }
            
            _service.Operate();
        }
    }

    
}
