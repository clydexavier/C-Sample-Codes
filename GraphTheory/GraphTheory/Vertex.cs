using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    internal class Vertex
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public double Value { get; set; }
        public bool Visited { get; set; }

        public Vertex Previous { get; set; }

        public Vertex(string name) 
        { 
            this.Name = name;
        }

        public Vertex(Vertex v)
        {
            this.Name = v.Name;
            this.Location = v.Location;
            this.Value = v.Value;
            this.Visited = v.Visited;
        }

        public Vertex(string name, double value) 
        { 
            this.Name = name;
            this.Value = value;
        }
    }
}
