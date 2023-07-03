using ATM.Interfaces;
using States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static States.Interfaces.IATMState;

namespace ATM.Classes
{
    public class StateFactory
    {
        static bool _set = false;
        private static void Set(CardChecker cardUser, ICredential credential, IBalance balance)
        {
            _state[0].SetSupport(credential, balance, cardUser);
            _state[1].SetSupport(credential, balance, cardUser);
            _state[2].SetSupport(credential, balance, cardUser);
            _set = true;
        }

        private static AbstractATM[] _state = new AbstractATM[3]
        {
            new DebitCardNotInsertedState(),
            new DebitCardInsertedState(),
            new PinEnteredState()
        };
        public static AbstractATM Get(ATMState state) => _set ? _state[(int)state] : throw new Exception(nameof(_set));
        public static Card IssueCard(string user) => _set ? _state[0].IssueCard(user) : throw new Exception(nameof(_set));
        public static void Initialize(CardChecker cardUser, ICredential credential, IBalance balance)
        {
            switch((cardUser, credential, balance))
            {
            case (null, _, _):
                throw new ArgumentNullException(nameof(cardUser));
            case (_, null, _):
                throw new ArgumentNullException(nameof(credential));
            case (_, _, null):
                throw new ArgumentNullException(nameof(balance));
            case (_, _, _):
                Set(cardUser, credential, balance);
                break;
            default:
                throw new Exception("StateFactory.SetSupport: should not be here.");
            };
        }
    }
}
