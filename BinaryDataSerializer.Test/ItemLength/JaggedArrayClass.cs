﻿namespace BinaryDataSerialization.Test.ItemLength
{
    public class JaggedArrayClass
    {
        [FieldOrder(0)]
        public int NameCount { get; set; }

        [FieldOrder(1)]
        [FieldCount(nameof(NameCount))]
        public int[] NameLengths { get; set; }

        [FieldOrder(2)]
        [FieldCount(nameof(NameCount))]
        [ItemLength(nameof(NameLengths))]
        public string[] NameArray { get; set; }
    }
}
