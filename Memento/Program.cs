using Memento.Classes;

namespace MementoNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Memento, Prototype, Flyweight\n");
            Test();
        }

        static void Test()
        {
            Originator originator = new Originator();

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LEDTV"));
            caretaker.AddMemento(originator.CreateMemento("LED50"));
            caretaker.AddMemento(originator.CreateMemento("LED46"));
            caretaker.AddMemento(originator.CreateMemento("LED4689")); //null
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LCDTV"));
            caretaker.AddMemento(originator.CreateMemento("LEDTV"));
            caretaker.AddMemento(originator.CreateMemento("LED50"));
            caretaker.AddMemento(originator.CreateMemento("LED46"));

            Console.WriteLine("Orignator Current State: \n" + originator.GetDetails());
            Console.WriteLine("CareTaker: \n" + caretaker.GetDetails());
        }
    }
}