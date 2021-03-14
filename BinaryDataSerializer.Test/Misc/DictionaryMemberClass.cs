using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Misc
{
    public class DictionaryMemberClass
    {
        public DictionaryMemberClass()
        {
            Field = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Field { get; set; }
    }
}
