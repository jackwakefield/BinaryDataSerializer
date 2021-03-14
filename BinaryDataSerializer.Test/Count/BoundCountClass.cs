using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Count
{
    public class BoundCountClass
    {
        [FieldOrder(0)]
        public ushort FieldCountField { get; set; }

        [FieldOrder(1)]
        [FieldCount(nameof(FieldCountField))]
        public List<string> Field { get; set; }
    }
}
