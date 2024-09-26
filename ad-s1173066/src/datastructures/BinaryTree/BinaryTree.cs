using System;

namespace AD
{
    public partial class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryNode<T> root;

        //----------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------

        public BinaryTree() { root = null; }

        public BinaryTree(T rootItem) : this()
        {
            root = new(rootItem);
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int SizeRecursive(BinaryNode<T> node)
        {
            if (node is null)
            {
                return 0;
            }

            return 1 + SizeRecursive(node.left) + SizeRecursive(node.right);
        }

        public int Size()
        {
            return SizeRecursive(root);
        }

        public int HeightRecursive(BinaryNode<T> node, int height)
        {
            if (node is null)
            {
                return -1;
            }

            return Math.Max(height, Math.Max(
                HeightRecursive(node.left, height + 1),
                HeightRecursive(node.right, height + 1)
            ));
        }

        public int Height()
        {
            return HeightRecursive(root, 0);
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root is null;
        }

        public void Merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            BinaryNode<T> rootLeft = t1 is null ? null : t1.GetRoot(),
                         rootRight = t2 is null ? null : t2.GetRoot();

            root = new(rootItem, rootLeft, rootRight);
        }

        public string ToPrefixString()
        {
            if (IsEmpty())
            {
                return "NIL";
            }

            return BinaryTreeWalker<T, string>.OperateOn(GetRoot(), (children, node) =>
            {
                return $"[ {node.GetData()} {children.Item1 ?? "NIL"} {children.Item2 ?? "NIL"} ]";
            });
        }

        public string ToInfixString()
        {
            if (IsEmpty())
            {
                return "NIL";
            }

            return BinaryTreeWalker<T, string>.OperateOn(GetRoot(), (children, node) =>
            {
                return $"[ {children.Item1 ?? "NIL"} {node.GetData()} {children.Item2 ?? "NIL"} ]";
            });
        }

        public string ToPostfixString()
        {
            if (IsEmpty())
            {
                return "NIL";
            }

            return BinaryTreeWalker<T, string>.OperateOn(GetRoot(), (children, node) =>
            {
                return $"[ {children.Item1 ?? "NIL"} {children.Item2 ?? "NIL"} {node.GetData()} ]";
            });
        }

        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public int NumberOfLeaves()
        {
            if (IsEmpty())
            {
                return 0;
            }

            return BinaryTreeWalker<T, int>.OperateOn(GetRoot(), (children, node) =>
            {
                if (node.IsLeaf())
                {
                    return 1;
                }

                return children.Item1 + children.Item2;
            });
        }

        public int NumberOfNodesWithOneChild()
        {
            if (IsEmpty())
            {
                return 0;
            }

            return BinaryTreeWalker<T, int>.OperateOn(GetRoot(), (children, node) =>
            {
                if (node.HasLeft() ^ node.HasRight())
                {
                    return 1;
                }

                return children.Item1 + children.Item2;
            });
        }

        public int NumberOfNodesWithTwoChildren()
        {
            if (IsEmpty())
            {
                return 0;
            }

            return BinaryTreeWalker<T, int>.OperateOn(GetRoot(), (children, node) =>
            {
                int total = children.Item1 + children.Item2;
                if (node.HasLeft() && node.HasRight())
                {
                    return total + 1;
                }

                return total;
            });
        }
    }
}
