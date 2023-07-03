using Automaton.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.Classes
{
    class Rule : IExpression
    {
        private readonly string StartRule = "S";
        private readonly string _rule;
        public Rule(string rule) => _rule = rule;
        public string Evaluate(string  expression) => expression.ReplaceFirst(StartRule, _rule, 0);          
        public override string ToString() => _rule;
    }
    public static class Utility
    {
        private static readonly string TerminalSign = "0";
        public static string ReplaceFirst(this string @this, string oldValue, string newValue, int startindex) =>
            (startindex = @this.IndexOf(oldValue)) == -1 ? @this
            : newValue == TerminalSign ? @this.Remove(startindex, oldValue.Length)
            : @this.Remove(startindex, oldValue.Length).Insert(startindex, newValue);
        public static bool CheckChars(this string @this, string str) =>
            (string.IsNullOrWhiteSpace(@this)) ? true
            : (string.IsNullOrWhiteSpace(str)) ? false
            : @this.All(x => str.Contains(x));
    }
}  
