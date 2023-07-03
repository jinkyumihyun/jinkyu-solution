using ATM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Interfaces
{
    public abstract class AbstractHandler
    {
        public enum Unit { FT = 5000, OT =1000, FH = 500, OH = 100, F = 50, T = 10, FV = 5, O = 1, N = 0}

        protected int _unit;
        protected AbstractHandler(Unit unit) => _unit = (int)unit;

        public AbstractHandler NextHandler;

        public AbstractHandler PrevHandler;
        public abstract bool DispatchNotes(long requestedAmount, long tmp = 0);
    }
}
