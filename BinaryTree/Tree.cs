namespace BinaryTree
    {
    public class Tree<TItem> where TItem : IComparable<TItem>, IPrinttree
        {
        public TItem NodeData { get; set; }
        public Tree<TItem>? LeftTree { get; set; }
        public Tree<TItem>? RightTree { get; set; }


        public Tree( TItem nodeValue )
            {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
            }

        public void Insert( TItem newItem )
            {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo( newItem ) > 0)
                {
                if (this.LeftTree is null)
                    {
                    this.LeftTree = new Tree<TItem>( newItem );
                    }
                else
                    {
                    this.LeftTree.Insert( newItem );
                    }

                }
            else
                {
                if (this.RightTree is null)
                    {
                    this.RightTree = new Tree<TItem>( newItem );
                    }
                else
                    {
                    this.RightTree.Insert( newItem );
                    }
                }
            }

        public string WalkTree( )
            {
            string result = "";
            if (this.LeftTree is not null)
                {
                result = this.LeftTree.WalkTree();
                }
            result += $" {this.NodeData.PrintNode()} ";
            if (this.RightTree is not null)
                {
                result += this.RightTree.WalkTree();
                }
            return result;
            }
        }
    }