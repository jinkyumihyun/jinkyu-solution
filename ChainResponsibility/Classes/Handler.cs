using ATM.Classes;
using ChainResponsibility.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Classes
{
    public class Handler : AbstractHandler
    {
        public Handler(Unit unit) : base(unit) { }
        public override bool DispatchNotes(long request, long tmp = 0) =>  //request: requestedAmount
            request <= 0 ? Helper.Write($"requestedAmount: {request} <= 0")
            : ((tmp = request / _unit) > 0 ? Helper.Write($"{tmp}  {_unit} note(s) are dispensed.") : Helper.Write(string.Empty))
            & ((tmp = request % _unit) > 0 ? NextHandler.DispatchNotes(tmp) : Helper.Write(string.Empty));
    }
}
