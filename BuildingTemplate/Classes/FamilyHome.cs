using BuildingTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingTemplate.Classes
{
    public class FamilyHome : AbstractBuilding
    {
        public override void Build()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls(); 
            BuildRoof();
            BuildWindows(); 
            BuildDoors();
            BuildAmenities();
            BuildInteriors();
            Console.WriteLine("Family home is done.\n");
        }   
        protected override void BuildFoundation() => Console.WriteLine("BuildFoundation");
        protected override void BuildPillars() => Console.WriteLine("BuildPillars");
        protected override void BuildWalls() => Console.WriteLine("BuildWalls");
        protected override void BuildRoof() => Console.WriteLine("BuildRoof");
        protected override void BuildWindows() => Console.WriteLine("BuildWindows");
        protected override void BuildInteriors() => Console.WriteLine("BuildInteriors");
        protected override void BuildDoors() => Console.WriteLine("BuildDoors");
        protected override void BuildAmenities() => Console.WriteLine("BuildAmenities");      
    }
}
