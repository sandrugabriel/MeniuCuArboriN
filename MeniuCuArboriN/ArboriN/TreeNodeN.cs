using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MeniuCuArboriN.ArboriN
{
    public class TreeNodeN<T> : IComparable<TreeNodeN<T>> where T : IComparable<T>
    {

        public List<TreeNodeN<T>> Children { get; set; }

        public T Value { get; set; }


        public int CompareTo(TreeNodeN<T> other)
        {
           return Value.CompareTo(other.Value);
        }
    }
}
