using System.Collections.Generic;

namespace BinaryDataSerialization.Test.ItemLength
{
    public class ItemConstLengthClass
    {
        [ItemLength(3)]
        public List<string> List { get; set; }
    }
}
