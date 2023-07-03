using Observer.Classes;
using Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Observers.Classes
{
    public class Market : ISubject
    {
        public Market(string name) => Name = name; 
        public string Name { get; }

        private List<ISubject> _subjects = new List<ISubject>();

        private List<IObserver> _observers = new List<IObserver>();

        private Dictionary<string, int> _products = new Dictionary<string, int>();

        private Dictionary<Guid, int> _noticeIds = new Dictionary<Guid, int>();
       
        public void SetPrice(string product, int price)
        {
            if (! _products.ContainsKey(product) || _products[product] != price)
            {
                Console.WriteLine("Product: " + product + ": Price: $" + price + $" is Now available on the \"{Name}\" store.");
                _products[product] = price;
                INotice notice = new Notice(product, price, Name);
                NotifyObservers(notice);
                NotifySubjects(notice, true);
            }
        }
        private void NotifyObservers(INotice notice) => _observers.ForEach(ob => ob.Update(notice));
        private void NotifySubjects(INotice notice, bool Origin)
        {
            if (_subjects.Count > 0)
            {
                _noticeIds.Add(notice.Id, Origin ? _subjects.Count : _subjects.Count - 1);
                _subjects.ForEach(ob => ob.Update(notice));
            }          
        }
        public void Update(INotice notice)
        {
            if (! _noticeIds.ContainsKey(notice.Id))
            {
                NotifySubjects(notice, false);
                _observers.ForEach(ob => ob.Update(notice));
            }
            else
            {
                _noticeIds[notice.Id] -= 1;
                if (_noticeIds[notice.Id] == 0)
                {
                    _noticeIds.Remove(notice.Id);
                }
            }           
        }
        public void RegisterSubject(ISubject subject)
        {
            if (! _subjects.Contains(subject))
            {
                _subjects.Add(subject);
                subject.RegisterSubject(this);
            }       
        }
        public void RemoveSubject(ISubject subject)
        {
            if (_subjects.Contains(subject))
            {
                _subjects.Remove(subject);
                subject.RemoveSubject(this);
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            if (observer is not null) 
            {
                _observers.Add(observer);
            } 
        }
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    }
}
