using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Count
{
    public class PaddedConstSizedListClass
    {
        [FieldCount(6)]
        public List<PaddedConstSizeListItemClass> Items { get; set; }
    }
}
