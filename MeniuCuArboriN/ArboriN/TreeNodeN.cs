using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MeniuCuArboriN.ArboriN
{
    public class TreeNodeN<T>
    {

        public List<TreeNodeN<T>> Children { get; set; }

        public T Value { get; set; }

        public bool IsExpend { get; set; }

    }
}
