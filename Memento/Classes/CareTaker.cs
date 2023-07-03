using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class Caretaker
    {
        private List<Memento> TvList = new List<Memento>();
        public void AddMemento(Memento? m) 
            =>  Helper.Do(() => { if (m is not null) { TvList.Add(m); } });
        public Memento? GetMemento(int index) => (index <  TvList.Count) ? TvList[index] : null;
        public string GetDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            TvList.ForEach(tv => stringBuilder.Append($"CareTaker: [{tv.GetDetails()}]\n"));
            return stringBuilder.ToString();
        }
    }
}
