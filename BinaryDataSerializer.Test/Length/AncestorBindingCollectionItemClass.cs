﻿namespace BinaryDataSerialization.Test.Length
{
    public class AncestorBindingCollectionItemClass
    {
        [FieldLength(nameof(AncestorBindingCollectionClass.ItemLength),
            RelativeSourceMode = RelativeSourceMode.FindAncestor, AncestorLevel = 3)]
        public string Value { get; set; }
    }
}
