using Automaton.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaton.Classes
{
    public class Context
    {
        public void Evaluate()
        {
            List<IExpression> rules = MakeRules();
            string Expression = "S";

            while (true)
            {              
                ShowRules(rules, Expression);

                int idx = GetOptionIndex(rules.Count);
                if (idx < 0)
                {
                    Console.ReadKey();
                    continue;
                }

                Expression = rules[idx].Evaluate(Expression);

                if (!Expression.Contains('S'))
                {
                    Console.WriteLine($"Expression: {Expression}\nBye!");
                    break;
                }
            }
        }
        List<IExpression> MakeRules()
        {
            Console.Clear();
            Console.WriteLine("Please type in a rule only using 'a', 'b', 'S'(capital S), or 0.");
            Console.WriteLine("Ex) aSa, bSb, or 0 to finish rule creation.\n");

            List<IExpression> tmpRules = new List<IExpression>();

            while (true)
            {
                string? ruleText = GetRuleText();
                if (ruleText is null)
                {
                    Console.ReadKey();
                    continue;
                }

                tmpRules.Add(new Rule(ruleText));
                Console.WriteLine($"a rule (S->{ruleText}) made.\n");
             
                if (ruleText.Contains('0')) 
                {
                    break;
                }
            }

            return tmpRules;
        }
        int GetOptionIndex(int indexCount)
        {
            Console.Write("Please choose one rule: ");
            string optionStr = GetStringConsole();
            if (!Int32.TryParse(optionStr, out int idx) || idx >= indexCount)
            {
                Console.WriteLine($"wrong format or value in option string: {optionStr}.\n");
                return -1;
            }
            return idx;
        }
        string GetStringConsole()
        {
            string? ruleStr = Console.ReadLine();
            string rule = string.IsNullOrWhiteSpace(ruleStr) ? string.Empty : ruleStr.Trim();
            return rule;
        }
        string? GetRuleText()
        {
            Console.WriteLine("Please type in a rule.");
            Console.Write("S -> ");

            string ruleStr = GetStringConsole();
            if (ruleStr.Length == 0 || ! ruleStr.CheckChars("abS0"))
            {
                Console.WriteLine($"empty rule string or wrong char in the rule string: {ruleStr}.\n");
                return null;
            }
            return ruleStr;
        }     
    void ShowRules(List<IExpression> rules, string Expression)
        {
            Console.Clear();
            Console.WriteLine($"Expression: {Expression}");
            int idx = 0;
            rules.ForEach(r => Console.Write($"{idx++}: S -> {r}    "));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
