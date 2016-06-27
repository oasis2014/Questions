using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class GraphQuestion
    {
        public static void AnswerQuestion()
        {
            Graph<int> g = new Graph<int>();
            for (int i = 0; i < 10; i++)
            {
                g.AddNode(i+1);
            }

            //g.AddUndirectedEdge(1, 2);
            //g.AddUndirectedEdge(1, 3);
            //g.AddUndirectedEdge(1, 5);
            //g.AddUndirectedEdge(2, 6);
            //g.AddUndirectedEdge(2, 7);
            //g.AddUndirectedEdge(3, 8);
            //g.AddUndirectedEdge(4, 9);
            //g.AddUndirectedEdge(5, 10);
            g.AddDirectedEdge(1, 2);
            g.AddDirectedEdge(1, 3);
            g.AddDirectedEdge(1, 5);
            g.AddDirectedEdge(2, 6);
            g.AddDirectedEdge(2, 7);
            g.AddDirectedEdge(3, 8);
            g.AddDirectedEdge(4, 9);
            g.AddDirectedEdge(5, 10);

            int s=1, e=8;
            Console.WriteLine("Is there a rount from {0} to {1}?", s, e);
            Console.WriteLine(Search(g, s, e));
            Console.ReadLine();
        }

        public static bool Search(Graph<int> g, int s, int e)
        {
            GraphNode<int> start = (GraphNode<int>)g.Nodes.FindByValue(s);
            GraphNode<int> end = (GraphNode<int>)g.Nodes.FindByValue(e);

            Queue<GraphNode<int>> queue = new Queue<GraphNode<int>>();
            queue.Enqueue(start);

            Dictionary<int, string> state = new Dictionary<int, string>();
            foreach (GraphNode<int> node in g.Nodes)
                state[node.Value] = "Not_Visited";

            state[1] = "Visiting";

            GraphNode<int> current = null;
            while (queue.Count != 0)
            {
                current = queue.Dequeue();
                foreach (GraphNode<int> v in current.Neighbors)
                {
                    if (state[v.Value] == "Not_Visited")
                    {
                        if (v.Value == e)
                            return true;
                        else
                        {
                            state[v.Value] = "Visiting";
                            queue.Enqueue(v);
                        }
                    }
                }
                state[current.Value] = "Visited";
            }
            return false;
        }
    }

    public class Graph<T> : IEnumerable<T>
    {
        private NodeList<T> nodeSet;

        public Graph() : this(null) { }
        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new NodeList<T>();
            else
                this.nodeSet = nodeSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (GraphNode<T> gnode in nodeSet)
                yield return gnode.Value;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return nodeSet.GetEnumerator();
        }

        public NodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public void AddNode(GraphNode<T> node)
        {
            nodeSet.Add(node);
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }

        public void AddNode(T value)
        {
            nodeSet.Add(new GraphNode<T>(value));
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost=1)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);

            to.Neighbors.Add(from);
            to.Costs.Add(cost);
        }

        public void AddUndirectedEdge(T from, T to, int cost =1)
        {
            GraphNode<T> frnode = (GraphNode<T>) nodeSet.FindByValue(from);
            GraphNode<T> tnode = (GraphNode<T>)nodeSet.FindByValue(to);

            frnode.Neighbors.Add(tnode);
            frnode.Costs.Add(cost);

            tnode.Neighbors.Add(frnode);
            tnode.Costs.Add(cost);
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost = 1)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddDirectedEdge(T from, T to, int cost = 1)
        {
            GraphNode<T> frnode = (GraphNode<T>)nodeSet.FindByValue(from);
            GraphNode<T> tnode = (GraphNode<T>)nodeSet.FindByValue(to);

            frnode.Neighbors.Add(tnode);
            frnode.Costs.Add(cost);
        }

        public void Clear()
        {
            nodeSet.Clear();
        }

        public bool Contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }
    }

    public class GraphNode<T> : Node<T>
    {
        private List<int> costs = new List<int>();

        public GraphNode() :base() { }

        public GraphNode(T value):base(value) {}

        public GraphNode(T value, NodeList<T> neighbors) : base(value, neighbors) { }

        new public NodeList<T> Neighbors
        {
            get
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>();

                return base.Neighbors;
            }
        }

        public List<int> Costs
        {
            get
            {
                if (costs == null)
                    costs = new List<int>();

                return costs;    
            }
        }
    }

    public class Node<T>
    {
        private T data;
        private NodeList<T> neighbors = null;

        public Node() { }
        public Node(T data) { this.data = data; }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value
        {
            get
            {
                return this.data;
            }
            set
            {
                data = value;
            }
        }

        public NodeList<T> Neighbors 
        {
            get
            {
                return this.neighbors;
            }
            set
            {
                neighbors = value;
            }
        }
    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }
        public NodeList(int intialSize)
        {
            for (int i=0; i<intialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (Node<T> node in Items)
            {
                if (node.Value.Equals(value))
                {
                    return node;
                }
            }
            return null;
        }

    }
}
