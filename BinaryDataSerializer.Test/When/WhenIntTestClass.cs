﻿namespace BinaryDataSerialization.Test.When
{
    public class WhenIntTestClass
    {
        [FieldOrder(4)]
        public int WhatToDo { get; set; }

        [FieldOrder(5)]
        [SerializeWhen(nameof(WhatToDo), (byte)1)]
        public int SerializeThis { get; set; }

        [FieldOrder(6)]
        [SerializeWhen(nameof(WhatToDo), (byte)2)]
        public int DontSerializeThis { get; set; }

        [FieldOrder(7)]
        [SerializeWhen(nameof(WhatToDo), (byte)1)]
        [SerializeWhen(nameof(WhatToDo), (byte)2)]
        public int SerializeThisNoMatterWhat { get; set; }
    }
}
