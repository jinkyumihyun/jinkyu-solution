using HelperLib;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Classes
{
    public class DayExpression : IExpression
    {
        readonly string Target;
        public DayExpression(string target) 
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Day.ToString());
    }

    public class MonthExpression : IExpression
    {
        readonly string Target;
        public MonthExpression(string target)
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Month.ToString());
    }

    public class YearExpression : IExpression
    {
        readonly string Target;
        public YearExpression(string target)
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Year.ToString());
    }
    class DaySeparatorExpression : IExpression
    {
        readonly string Target = " ";
        readonly string Source = "-";
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, Source);
    }
    class TimeSeparatorExpression : IExpression
    {
        readonly string Target = "_";
        readonly string Source = ":";
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, Source);
    }
    public class HourExpression : IExpression
    {
        readonly string Target;
        public HourExpression(string target)
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Hour.ToString());
    }
    public class MinuteExpression : IExpression
    {
        readonly string Target;
        public MinuteExpression(string target)
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Minute.ToString());
    }
    public class SecondExpression : IExpression
    {
        readonly string Target;
        public SecondExpression(string target)
            => Target = Helper.IsNullWhite(target) ?? throw new ArgumentException(nameof(target));
        public void Evaluate(Context context)
            => context.Expression = context.Expression.Replace(Target, context.Date.Second.ToString());
    }

}
