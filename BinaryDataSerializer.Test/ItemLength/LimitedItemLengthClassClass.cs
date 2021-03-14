using System.Collections.Generic;

namespace BinaryDataSerialization.Test.ItemLength
{
    public class LimitedItemLengthClassClass
    {
        [ItemLength(3)]
        public List<LimitedItemLengthClassInnerClass> InnerClasses { get; set; }
    }
}
