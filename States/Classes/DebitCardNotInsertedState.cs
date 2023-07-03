using ATM.Interfaces;
using States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static States.Interfaces.IATMState;

namespace ATM.Classes
{
    public class DebitCardNotInsertedState : AbstractATM
    {
        public override AbstractATM InsertDebitCard(Card card)
            => _cardUser.Insert(card) ? StateFactory.Get(ATMState.DebitCardInserted) : StaySameState();
        protected override AbstractATM StaySameState() 
            => StateFactory.Get(ATMState.DebitCardNotInserted);
    }
}