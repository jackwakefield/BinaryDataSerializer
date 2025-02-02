﻿namespace BinaryDataSerialization.Test.Subtype
{
    public class AncestorSubtypeBindingContainerClass
    {
        [FieldOrder(0)]
        public int Selector { get; set; }

        [FieldOrder(1)]
        [Subtype(nameof(Selector), 1, typeof(AncestorSubtypeBindingClass))]
        public AncestorSubtypeBindingBaseClass AncestorSubtypeBindingClass { get; set; }
    }
}
