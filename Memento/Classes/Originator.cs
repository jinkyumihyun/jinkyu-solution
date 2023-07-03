using HelperLib;
using Memento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class Originator
    {
        public Dictionary<string, ITV> TVs = new Dictionary<string, ITV>()
        {         
            ["LCDTV"] = LCDTV.Create("40-Inch", "1000", true),  //sample
            ["LEDTV"] = LEDTV.Create("60-Inch", "2000", true),
            ["TubeTV"] = TubeTV.Create("20-Inch", "200", false),
            ["LED46"] = LEDTV.Create("46-Inch", "1500", true),
            ["LED50"] = LEDTV.Create("50-Inch", "1800", true)
        };    
        public Memento? CreateMemento(string type) 
            => Helper.IsNullWhiteBool(type) ? null
            : TVs.ContainsKey(type) ? Memento.Create(TVs[type]) : null;
        public string GetDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            TVs.Values.ToList().ForEach(tv => stringBuilder.Append($"Originator: [{tv.GetDetails()}]\n"));
            return stringBuilder.ToString();
        }
    }
}
