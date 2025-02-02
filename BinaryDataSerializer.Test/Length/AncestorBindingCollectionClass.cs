﻿using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Length
{
    public class AncestorBindingCollectionClass
    {
        [FieldOrder(0)]
        public int ItemLength { get; set; }

        [FieldOrder(1)]
        public List<AncestorBindingCollectionItemClass> Items { get; set; }
    }
}
