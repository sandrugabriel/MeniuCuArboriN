using MeniuCuArboriN.ArboriN.interfaces;
using MeniuCuArboriN.View.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeniuCuArboriN.ArboriN
{
    public class ArboriN<T> : IArboriN<T> where T : Button
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
                if(node.Value == value)
                {
                    return node;
                }

                for(int i=0;i<node.Children.Count;i++)
                {
                    if (node.Children[i].Value == value) return node.Children[i];

                    if(i >= node.Children.Count-1)
                     return findByValue(node.Children[i], value);
                }

            }

            return null;
        }

        public List<T> findByNode(TreeNodeN<T> node, TreeNodeN<T> parent)
        {
            if (node != null)
            {
                if (node == parent)
                {
                    List<T> list = new List<T>();
                    for (int i = 0; i < parent.Children.Count; i++)
                        list.Add(parent.Children[i].Value);
                    return list;
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                    return findByNode(node.Children[i], parent);
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
                    if (node.Children[i].Value.Text == value.Text)
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
                if (parinte.Children[i].Value.Text == value.Text)
                {
                    parinte.Children.RemoveAt(i);
                }
            }
        
        
        }

        public TreeNodeN<T> findByValue1(TreeNodeN<T> node, T value)
        {
            if (node != null)
            {
                if (node.Value== value)
                {
                    return node;
                }

                for (int i = 0; i < node.Children.Count; i++)
                {
                    return findByValue1(node.Children[i], value);
                }
            }

            return null;
        }

        public List<T> getTsByChildren(TreeNodeN<T> node)
        {
            List<T> ts = new List<T>();

            if(node.Children != null)
            for(int i=0;i<node.Children.Count;i++)
            {
                    ts.Add(node.Children[i].Value);
            }

            return ts;
        }

        public List<T> getTsByAllChildren(TreeNodeN<T> node)
        {
            List<T> ts = new List<T>();

            if (node.Children != null)
                for (int i = 0; i < node.Children.Count; i++)
                {
                    ts.Add(node.Children[i].Value);
                    for(int k = 0; k < node.Children[i].Children.Count; k++)
                    {
                        ts.Add(node.Children[i].Children[k].Value);
                    }
                }

            return ts;
        }

        public TreeNodeN<T> findNode(TreeNodeN<T> node, T btn)
        {
            if (node.Children != null)
                for (int i = 0; i < node.Children.Count; i++)
                {
                    if (node.Children[i].Value == btn) return node.Children[i];
                    else
                        for (int k = 0; k < node.Children[i].Children.Count; k++)
                        {
                            if (node.Children[i].Children[k].Value == btn)
                            {
                                return node.Children[i].Children[k];
                            }
                        }
                }

            return null;
        }

    }
}
