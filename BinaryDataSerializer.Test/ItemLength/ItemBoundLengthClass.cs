using System.Collections.Generic;

namespace BinaryDataSerialization.Test.ItemLength
{
    public class ItemBoundLengthClass
    {
        [FieldOrder(0)]
        public int ItemLength { get; set; }

        [FieldOrder(1)]
        [ItemLength(nameof(ItemLength))]
        public List<string> Items { get; set; }
    }
}
