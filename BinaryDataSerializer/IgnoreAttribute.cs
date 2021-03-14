using System;

namespace BinaryDataSerialization
{
    /// <summary>
    ///     Instructs <see cref="BinaryDataSerializer" /> not to serialize or deserialize the public field or property value.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class IgnoreAttribute : Attribute
    {
    }
}
