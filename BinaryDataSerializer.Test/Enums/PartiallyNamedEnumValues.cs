namespace BinaryDataSerialization.Test.Enums
{
    public enum PartiallyNamedEnumValues
    {
        [SerializeAsEnum] A,
        [SerializeAsEnum] B,
        C
    }
}
