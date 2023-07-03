using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingTemplate.Interfaces
{
    public abstract class AbstractBuilding
    {
        public abstract void Build();
        protected virtual void BuildFoundation() { }
        protected virtual void BuildPillars() { }
        protected virtual void BuildWalls() { }
        protected virtual void BuildRoof() { }
        protected virtual void BuildWindows() { }
        protected virtual void BuildDoors() { }
        protected virtual void BuildInteriors() { }
        protected virtual void BuildAmenities() { }
    }
}

