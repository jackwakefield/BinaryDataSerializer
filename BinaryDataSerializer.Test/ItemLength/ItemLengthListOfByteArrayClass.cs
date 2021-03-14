using System.Collections.Generic;

namespace BinaryDataSerialization.Test.ItemLength
{
    public class ItemLengthListOfByteArrayClass
    {
        [ItemLength(3)]
        public List<byte[]> Arrays { get; set; }
    }
}
