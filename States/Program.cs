using ATM.Classes;

namespace States
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: State, Factory, Flyweight\n");
            test();
        }
        class AAA { }
        static void test()
        {
            var credentialTester = new Credential(CredentialFactory.GetCredentials());
            Console.WriteLine();

            var balanceDB = new Balance(BalaceFactory.GetBalances());
            Console.WriteLine();

            var cardTester = new CardChecker();

            StateFactory.Initialize(cardTester, credentialTester, balanceDB);
            var johnCard = StateFactory.IssueCard("john");

            var atm = new ATMMachine();
            Console.WriteLine("john's case");
            atm.InsertDebitCard(johnCard);
            atm.EnterPin("1234");
            atm.WithdrawMoney(3000);
            atm.SaveMoney(5000);
            atm.EjectDebitCard();
            Console.WriteLine();

            Console.WriteLine("error cases");
            atm.EjectDebitCard();
            atm.EnterPin("1234");
            atm.WithdrawMoney(3000);
            Console.WriteLine();

            Console.WriteLine("jenny's case");
            var jennyCard = StateFactory.IssueCard("jenny");
            atm.InsertDebitCard(johnCard);
            Console.WriteLine("wrong password");
            atm.EnterPin("8888");//wrong password
            atm.WithdrawMoney(3000);
            atm.EjectDebitCard();
        }
    }
}