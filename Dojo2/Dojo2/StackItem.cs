using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo2
{
    class StackItem<T> //eligible for saving every data type
    {
        public T ItemValue { get; set; } //value of this item

        public StackItem<T> Predecessor { get; set; } /// predecessor of this item - the item added before the current item was added
    }
}
