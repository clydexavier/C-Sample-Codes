using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    internal class Graph
    {
        private List<Vertex> vertices;
        private Dictionary<string, int> nodename_to_index;
        private bool[,] adjacency_mtx;
        private double[,] cost_mtx;

        public Graph(string[] node_names)
        {
            this.vertices = new List<Vertex>();
            this.nodename_to_index = new Dictionary<string, int>();
            this.adjacency_mtx = new bool[node_names.Length, node_names.Length];
            foreach(string s in node_names)
            {
                this.nodename_to_index.Add(s, this.vertices.Count);
                this.vertices.Add(new Vertex(s));
            }
        }

        public int getVertexNumber(string vertex_name) 
        {
            return this.nodename_to_index[vertex_name];
        }

        public bool connectVertices(string vertex1_name, string vertex2_name, double cost)
        {
            try
            {
                adjacency_mtx[this.nodename_to_index[vertex1_name], this.nodename_to_index[vertex2_name]] =
                    adjacency_mtx[this.nodename_to_index[vertex2_name], this.nodename_to_index[vertex1_name]] =
                        true;
                cost_mtx[this.nodename_to_index[vertex1_name], this.nodename_to_index[vertex2_name]] =
                    cost_mtx[this.nodename_to_index[vertex2_name], this.nodename_to_index[vertex1_name]] =
                        cost;
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }

        public string DijkstraShortestPath(string start_vertex_name, string goal_vertex_name)
        {
            string path = "";

            Vertex current = this.vertices[this.nodename_to_index[start_vertex_name]];

            PriorityQueue<Vertex, double> pq = new PriorityQueue<Vertex, double>();

            while(!current.Name.Equals(goal_vertex_name)) 
            { 
                for(int i=0; i < adjacency_mtx.Length; i++)
                {
                    if (this.adjacency_mtx[i, this.nodename_to_index[current.Name]])
                    {
                        Vertex v = new Vertex(this.vertices[i]);
                    }

                }
            }

            return path;
        }
    }
}
