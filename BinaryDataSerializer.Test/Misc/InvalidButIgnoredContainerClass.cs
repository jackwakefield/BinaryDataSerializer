namespace BinaryDataSerialization.Test.Misc
{
    public class InvalidButIgnoredContainerClass
    {
        public int A;

        [Ignore]
        public InvalidButIgnoredTypeClass InvalidButIgnored;
    }
}
