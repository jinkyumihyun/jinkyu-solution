using ATM.Classes;
using States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    public abstract class AbstractATM : IATMState
    {
        protected ICredential _credential;
        protected IBalance _balance;
        protected CardChecker _cardUser;

        public void SetSupport(ICredential credential, IBalance balance, CardChecker cardUser)
        {
            _credential = credential;
            _balance = balance;
            _cardUser = cardUser;
        }
        public Card IssueCard(string user) => _cardUser.IssueCard(user);
        protected abstract AbstractATM StaySameState();
        public virtual AbstractATM InsertDebitCard(Card card)
        { 
            return StaySameState();
        }
        public virtual AbstractATM EjectDebitCard()
        {
            return StaySameState();
        }
        public virtual AbstractATM EnterPin(string pin)
        {
             return StaySameState();
        }
        public virtual AbstractATM WithdrawMoney(int amount)
        { 
            return StaySameState();
        }
        public virtual AbstractATM SaveMoney(int amount)
        {
            return StaySameState();
        }
    }
}
