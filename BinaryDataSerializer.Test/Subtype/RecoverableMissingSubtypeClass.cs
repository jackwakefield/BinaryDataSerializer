using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Subtype
{
    public class RecoverableMissingSubtypeClass<T>
    {
        public List<T> Items { get; set; }
    }
}
