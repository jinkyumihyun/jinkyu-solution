using HelperLib;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes
{
    public class Context
    {
        List<IExpression> _objExpressions = new List<IExpression>();
        public string Expression { get; set; }
        public DateTime Date { get; }
        public Context(DateTime date)
        {
            Date = date;
            MakeExpressionList();
        }
        public void Evaluate()
        {
            _objExpressions.ForEach(e => e.Evaluate(this));
            Console.WriteLine(Expression);
        }

        string GetDayFormat()
        {
            while (true)
            {
                Console.WriteLine("Please Select the Day Expression format : 0)\"MM DD YYYY\" or 1)\"YYYY MM DD\" or 2)\"DD MM YYYY\".");
                switch (Helper.GetSelectingChar(Console.ReadLine()))
                {
                    case '0':
                        return "MM DD YYYY";
                    case '1':
                        return "YYYY MM DD";
                    case '2':
                        return "DD MM YYYY";
                    default:
                        Console.WriteLine($"Wrong input");
                        break;
                }
            }
        }
        string GetTimeFormat()
        {
            while (true)
            {
                Console.WriteLine("Please Select the Time Expression format.: 0)\"HH MM SS\" or 1)\"HH MM\", or 2)no time.");
                switch (Helper.GetSelectingChar(Console.ReadLine()))
                {
                    case '0':
                        return "_hh_mm_ss";
                    case '1':
                        return "_hh_mm";
                    case '2':
                        return string.Empty;
                    default:
                        Console.WriteLine($"Wrong input");
                        break;
                }
            }
        }
        void MakeExpressionList()
        {
            Expression = GetDayFormat();
            Expression += GetTimeFormat();
            string[] strArray = Expression.Split(new char[] {' ', '_' }, StringSplitOptions.RemoveEmptyEntries);
            strArray.ToList().ForEach(e => _objExpressions.Add(Factory.Create(e)));
            _objExpressions.Add(new DaySeparatorExpression());
            _objExpressions.Add(new TimeSeparatorExpression());
        }
    }
}
//hh, mm, ss