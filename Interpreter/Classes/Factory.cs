using Interpreter.Classes;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes
{
    public class Factory
    {
        public static IExpression Create(string exp) =>
            exp switch
            {
                "DD" => new DayExpression(exp),
                "MM" => new MonthExpression(exp),
                "YYYY" => new YearExpression(exp),
                "hh" => new HourExpression(exp),
                "mm" => new MinuteExpression(exp),
                "ss" => new SecondExpression(exp),
                _ => throw new Exception("Factory.Create._")
            };
    }
}
