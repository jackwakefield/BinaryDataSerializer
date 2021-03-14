namespace BinaryDataSerialization
{
    internal interface IConstAttribute : IBindableFieldAttribute
    {
        object GetConstValue();
    }
}
