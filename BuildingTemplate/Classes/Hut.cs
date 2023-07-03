using BuildingTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingTemplate.Classes
{
    public class Hut : AbstractBuilding
    {
        public override void Build()
        {
            BuildFoundation(); 
            BuildPillars();       
            BuildRoof();
           
            Console.WriteLine("Hut is done.\n");
        }
        protected override void BuildFoundation() => Console.WriteLine("BuildFoundation");
        protected override void BuildPillars() => Console.WriteLine("BuildPillars");
        protected override void BuildWalls() => Console.WriteLine("BuildWalls");
        protected override void BuildRoof() => Console.WriteLine("BuildRoof");      
    }
}
