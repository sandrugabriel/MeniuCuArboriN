using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeniuCuArboriN.ArboriN.interfaces
{
    public interface IArboriN<T> where T : Button
    {

        TreeNodeN<T> getNode();

        void afisare(TreeNodeN<T> node);

        TreeNodeN<T> findByValue(TreeNodeN<T> node, T value);

        void Add(T parinte, T value);

        TreeNodeN<T> findByChild(TreeNodeN<T> node, T value);

        void Delete(T value);

    }
}
