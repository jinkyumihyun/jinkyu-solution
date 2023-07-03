using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Observer.Classes
{
    public class Publisher
    {
        private Dictionary<string, int> _products = new Dictionary<string, int>();
        public void SetPrice(string product, int price)
        {
            if (!_products.ContainsKey(product) || _products[product] != price)
            {
                _products[product] = price;
                 RaisePublishEvent($"product: {product}; price: {price}");
            }
        }

        public delegate void EventHandler(object sender, EventArgument e);

        public event EventHandler? PublishEvent;
        private void RaisePublishEvent(string msg) => PublishEvent?.Invoke(this, new EventArgument(msg));  
        public void AskPrice(string product)
        {
            string msg = _products.ContainsKey(product) ? 
                      $"product: {product}; price: {_products[product]}" : $"no such product: {product}";         
            RaiseAskEvent(msg);
        }

        public event EventHandler? AskEvent;
        private void RaiseAskEvent(string msg) => AskEvent?.Invoke(this, new EventArgument(msg));
    }
}
