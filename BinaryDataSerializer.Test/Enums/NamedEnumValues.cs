namespace BinaryDataSerialization.Test.Enums
{
    public enum NamedEnumValues
    {
        [SerializeAsEnum("Alpha")] A,
        [SerializeAsEnum("Bravo")] B,
        [SerializeAsEnum] C
    }
}
