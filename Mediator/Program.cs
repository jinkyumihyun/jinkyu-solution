using Mediator.Classes;
using Mediator.Interfaces;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Design patterns: Mediator\n");
            Test();
        }
        static void Test()
        {
            IMediator facebookMediator = new ConcreteFacebookGroupMediator();
            //Create instances of Colleague i.e. Creating users
            User Ram = new ConcreteUser("Ram");
            User Dave = new ConcreteUser("Dave");
            User Smith = new ConcreteUser("Smith");
            User Rajesh = new ConcreteUser("Rajesh");
            User Sam = new ConcreteUser("Sam");
            User Pam = new ConcreteUser("Pam");
            User Anurag = new ConcreteUser("Anurag");
            User John = new ConcreteUser("John");
            //Registering the users with the Mediator i.e. Facebook Group
            facebookMediator.RegisterUser(Ram);
            facebookMediator.RegisterUser(Dave);
            facebookMediator.RegisterUser(Smith);
            facebookMediator.RegisterUser(Rajesh);
            facebookMediator.RegisterUser(Sam);
            facebookMediator.RegisterUser(Pam);
            facebookMediator.RegisterUser(Anurag);
            facebookMediator.RegisterUser(John);

            IMediator facebookMediator2 = new ConcreteFacebookGroupMediator();
            //Create instances of Colleague i.e. Creating users
            User Ramh = new ConcreteUser("Ramh");
            User Dave000 = new ConcreteUser("Dave000");
            User Smithy = new ConcreteUser("Smithy");
            User Rajeshtan = new ConcreteUser("Rajeshtan");
            User Samuel = new ConcreteUser("Samuel");
            User Pamela = new ConcreteUser("Pamela");
            User Anuragnho = new ConcreteUser("Anuragnho");
            User Johnson = new ConcreteUser("Johnson");
            //Registering the users with the Mediator i.e. Facebook Group
            facebookMediator2.RegisterUser(Ramh);
            facebookMediator2.RegisterUser(Dave000);
            facebookMediator2.RegisterUser(Smithy);
            facebookMediator2.RegisterUser(Rajeshtan);
            facebookMediator2.RegisterUser(Samuel);
            facebookMediator2.RegisterUser(Pamela);
            facebookMediator2.RegisterUser(Anuragnho);
            facebookMediator2.RegisterUser(Johnson);

            IMediator facebookMediator3 = new ConcreteFacebookGroupMediator();
            //Create instances of Colleague i.e. Creating users
            User Ramhin = new ConcreteUser("Ramhin");
            User Dave000567 = new ConcreteUser("Dave000567");
            User Smithying = new ConcreteUser("Smithying");
            User Rajeshtanil = new ConcreteUser("Rajeshtanil");
            User Samuelala = new ConcreteUser("Samuelala");
            User Pamelalala = new ConcreteUser("Pamelalala");
            User Anuragnhov = new ConcreteUser("Anuragnhov");
            User Johnsoning = new ConcreteUser("Johnsoning");
            //Registering the users with the Mediator i.e. Facebook Group
            facebookMediator3.RegisterUser(Ramhin);
            facebookMediator3.RegisterUser(Dave000567);
            facebookMediator3.RegisterUser(Smithying);
            facebookMediator3.RegisterUser(Rajeshtanil);
            facebookMediator3.RegisterUser(Samuelala);
            facebookMediator3.RegisterUser(Pamelalala);
            facebookMediator3.RegisterUser(Anuragnhov);
            facebookMediator3.RegisterUser(Johnsoning);

            ISuperMediator super = new SuperMediator();
            super.RegisterMediator(facebookMediator3);
            super.RegisterMediator(facebookMediator2);
            super.RegisterMediator(facebookMediator);

            //One of the users Sending one Message in the Facebook Group
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            Ramhin.Send("This is a special message from Ramhin.");
            Console.WriteLine();
        }
    }
}