﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class Parent : IElement
    {
        public string Name { get; }
        public Parent(string name) => Name = name;
        public string ParentOperation() => $"\"ParentOperation\"";
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
