using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumWithGenerics
{
    public class MaximumValue<TType> where TType:IComparable
    {
        TType[] values;
        public MaximumValue(TType[] values)
        {
            this.values = values;
        }
        public TType GetMaximum()
        {
            Array.Sort(values);
            return values[^1];
        }
    }
}
