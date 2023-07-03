using ChainResponsibility.Classes;
using ChainResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChainResponsibility.Interfaces.AbstractHandler;

namespace ATM.Classes
{
    public class InstallFactory
    { 
        public static void Create(ref AbstractHandler? handler, Unit unit)
        {
            if (! Enum.IsDefined(unit))
            {
                throw new ArgumentException("unit value not in AbstractHandler.Unit");
            }
           
            AbstractHandler? tmp = handler;
            while (handler != null)
            {
                handler = handler.NextHandler;
            }
            handler = new Handler(unit);

            if(tmp != null)
            {
                tmp.NextHandler = handler;
            }          
            handler.PrevHandler = tmp;
        }
        public static void CreateAll(ref AbstractHandler? handler)
        {
            Create(ref handler, Unit.FT);
            Create(ref handler, Unit.OT);
            Create(ref handler, Unit.FH);
            Create(ref handler, Unit.OH);
            Create(ref handler, Unit.F);
            Create(ref handler, Unit.T);
            Create(ref handler, Unit.FV);
            Create(ref handler, Unit.O);
            while (handler?.PrevHandler != null)
            {
                handler = handler.PrevHandler;
            }            
        }
    }
}