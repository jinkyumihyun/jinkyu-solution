using ATM.Classes;
using ATM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace States.Interfaces
{
    public interface IATMState
    {
        enum ATMState
        {
            DebitCardNotInserted,
            DebitCardInserted,
            PinEntered
        }
        AbstractATM InsertDebitCard(Card card);
        AbstractATM EjectDebitCard();
        AbstractATM EnterPin(string pin);
        AbstractATM WithdrawMoney(int amount);
    }
}
