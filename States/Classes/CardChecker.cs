using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ATM.Classes
{
    public class CardChecker
    {
        List<string> _issuees = new List<string>();

        Guid _guid = Guid.NewGuid();
        private Card? _card = null;

        public string Name() => _card is not null ? _card.Name : string.Empty; 
        public bool Insert(Card card)
        => _card is not null ? Helper.Write($"A card already in the slot.", false)
            : card is null ? Helper.Write($"card is null", false)
            : (_issuees.Contains(card.Name) && _guid == card.Guid) ?
            Helper.Do(() => { Console.WriteLine($"card({card.Name}) inserted and accepted"); _card = card; })
            : Helper.Write($"card({card.Name}) inserted and rejected", false);
        public void Eject()
        {
            if ( _card == null )
            {
                Console.WriteLine($"no card in the slot.");
                return;
            }
            Console.WriteLine($"card({_card.Name}) ejected");
            _card = null;
        }
        public Card IssueCard(string name) 
        { 
            if (!_issuees.Contains(name))
            {
                _issuees.Add(name);
            }
            return new Card(name, _guid);
        }
    }

    public  class Card
    {
        public Guid Guid { get; }
        public string Name { get;}
        public Card(string name, Guid guid) => (Name, Guid) = (name, guid);
    } 
}
