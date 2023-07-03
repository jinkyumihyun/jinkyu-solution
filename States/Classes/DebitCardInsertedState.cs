using ATM.Interfaces;
using States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static States.Interfaces.IATMState;

namespace ATM.Classes
{
    public class DebitCardInsertedState : AbstractATM
    {
        public override AbstractATM EjectDebitCard() 
        {
            _cardUser.Eject();
            return StateFactory.Get(ATMState.DebitCardNotInserted);
        }
        public override AbstractATM EnterPin(string pin)
            => _credential.Check(_cardUser.Card.Name, pin) ? StateFactory.Get(ATMState.PinEntered) : StaySameState();
        protected override AbstractATM StaySameState() 
            => StateFactory.Get(ATMState.DebitCardInserted);
    }
}
