using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Count
{
    public class ConstCountClass<T>
    {
        [FieldOrder(0)]
        [FieldCount(3)]
        public List<T> Field { get; set; }

        [FieldOrder(1)]
        [FieldCount(3)]
        public T[] Field2 { get; set; }
    }
}
