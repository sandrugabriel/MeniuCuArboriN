using MeniuCuArboriN.ArboriN.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeniuCuArboriN.ArboriN
{
    public class ArboriN<T> : IArboriN<T> where T : IComparable<T>
    {

        private TreeNodeN<T> _root = null;

        public TreeNodeN<T> getNode()
        {
            return _root;
        }

        public void afisare(TreeNodeN<T> node)
        {
            if(node != null)
            {
                MessageBox.Show(node.Value.ToString());

                if(node.Children != null)
                {
                    for(int i=0;i<node.Children.Count;i++)
                    {
                        afisare(node.Children[i]);
                    }
                }

            }
        }

        public TreeNodeN<T> findByValue(TreeNodeN<T> node, T value)
        {
            if(node != null)
            {
                if(node.Value.CompareTo(value) == 1)
                {
                    return node;
                }

                for(int i=0;i<node.Children.Count;i++)
                {
                    return findByValue(node.Children[i], value);
                }
            }

            return null;
        }

        public void Add(T parinte, T value)
        {

            if(_root == null || parinte == null)
            {
                _root = new TreeNodeN<T>();
                _root.Value = value;
                _root.Children = new List<TreeNodeN<T>>();
            }
            else
            {
                TreeNodeN<T> aux = findByValue(_root, parinte);
                TreeNodeN<T> nou = new TreeNodeN<T>();
                nou.Value = value;
                nou.Children = new List<TreeNodeN<T>>();

                if(aux.Children !=null)
                    aux.Children.Add(nou);
                else
                    aux.Children = new List<TreeNodeN<T>>() { nou };
            }

        }

        public TreeNodeN<T> findByChild(TreeNodeN<T> node, T value)
        {
            if(node != null)
            {
                for(int i=0;i<node.Children.Count;i++)
                {
                    if (node.Children[i].Value.CompareTo(value) == 1)
                    {
                        return node;
                    }
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                   
                    return findByChild(node.Children[i], value);
                }
            }

            return null;
        }

        public void Delete(T value) {

            TreeNodeN<T> parinte = findByChild(_root, value);

            for(int i = 0; i < parinte.Children.Count; i++)
            {
                if (parinte.Children[i].Value.CompareTo(value) == 1)
                {
                    parinte.Children.RemoveAt(i);
                }
            }
        
        
        }



    }
}
