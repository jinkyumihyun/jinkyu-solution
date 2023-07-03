using Interpreter.Classes;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes2
{
    public class Factory
    {
        public static List<IExpression> Create(string expStr)
        {
            Dictionary<string, string> dateTime = new Dictionary<string, string>();
            DateTime Date = DateTime.Now;

            string[] strArray = expStr.Split(new char[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries);
            strArray.ToList().ForEach(e => dateTime.Add(e, Map(e, Date)));
            dateTime.Add(" ", Map(" ", Date));
            dateTime.Add("_", Map("_", Date));

            List<IExpression> tmp = new List<IExpression>();
            dateTime.Keys.ToList().ForEach( k => tmp.Add(new Expression(k, dateTime[k])));
            return tmp;
        }
        static string Map(string expPiece, DateTime Date) =>
        expPiece switch
        {
            "DD" => Date.Day.ToString(),
            "MM" => Date.Month.ToString(),
            "YYYY" => Date.Year.ToString(),
            "hh" => Date.Hour.ToString(),
            "mm" => Date.Minute.ToString(),
            "ss" => Date.Second.ToString(),
            " " => "-",
            "_" => ":",
            _ => throw new Exception("Factory.Map")
        };
    }
}
