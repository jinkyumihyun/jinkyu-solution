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
    internal class PinEnteredState : AbstractATM
    {
        public override AbstractATM EjectDebitCard()
        {
            _cardUser.Eject();
            return StateFactory.Get(ATMState.DebitCardNotInserted);
        }
        public override AbstractATM WithdrawMoney(int amount)
        {
            _balance.Withdraw(_cardUser.Name(), amount);
            return StaySameState();
        }
        public override AbstractATM SaveMoney(int amount)
        {
            _balance.Save(_cardUser.Name(), amount);
            return StaySameState();
        }
        protected override AbstractATM StaySameState()
            => StateFactory.Get(ATMState.PinEntered);

       
    }
}
