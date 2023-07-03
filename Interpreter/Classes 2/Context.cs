using HelperLib;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes2
{
    public class Context
    {
        public string Expression { get; set; }
    
        public void Evaluate()
        {
            var expList = MakeExpressionList();
            expList.ForEach(e => e.Evaluate(this));
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
                        Console.WriteLine($"Wrong input string");
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
                        Console.WriteLine($"Wrong input string");
                        break;
                }
            }
        }
        List<IExpression> MakeExpressionList()
        {
            Expression = GetDayFormat();
            Expression += GetTimeFormat();
            return Factory.Create(Expression);
        }
    }
}
//hh, mm, ss