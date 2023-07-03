using ATM.Interfaces;
using States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static States.Interfaces.IATMState;

namespace ATM.Classes
{
    public class ATMMachine 
    {
        private AbstractATM _atmMachineState = StateFactory.Get(ATMState.DebitCardNotInserted);
        public void InsertDebitCard(Card card)
            => _atmMachineState = _atmMachineState.InsertDebitCard(card);
        public void EjectDebitCard() 
            =>  _atmMachineState = _atmMachineState.EjectDebitCard();
        public void EnterPin(string pin) 
            => _atmMachineState = _atmMachineState.EnterPin(pin);          
        public void WithdrawMoney(int amount)
            => _atmMachineState = _atmMachineState.WithdrawMoney(amount);
        public void SaveMoney(int amount)
            => _atmMachineState = _atmMachineState.SaveMoney(amount);
    }
}

