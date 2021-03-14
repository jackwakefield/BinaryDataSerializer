using System;
using System.Reflection;

namespace BinaryDataSerialization
{
    /// <summary>
    ///     Used to represent context for the current serialization operation, such as the serialization ancestry.
    ///     <seealso cref="IBinaryDataSerializable" />
    /// </summary>
    internal class LazyBinaryDataSerializationContext : BinaryDataSerializationContext
    {
        private readonly Lazy<BinaryDataSerializationContext> _lazyContext;

        /// <summary>
        ///     Initializes a new instance of the BinaryDataSerializationContext class with a parent, parentType, and parentContext.
        /// </summary>
        public LazyBinaryDataSerializationContext(Lazy<BinaryDataSerializationContext> lazyContext)
        {
            _lazyContext = lazyContext;
        }

        /// <summary>
        ///     The value of the object being serialized.
        /// </summary>
        public override object Value => _lazyContext.Value.Value;

        /// <summary>
        ///     The type of the parent.
        /// </summary>
        public override Type ParentType => _lazyContext.Value.ParentType;

        /// <summary>
        ///     The parent value in the object graph of the object being serialized.
        /// </summary>
        public override object ParentValue => _lazyContext.Value.ParentValue;

        /// <summary>
        ///     The parent object serialization context.
        /// </summary>
        public override BinaryDataSerializationContext ParentContext => _lazyContext.Value.ParentContext;

        /// <summary>
        ///     The member info for the object being serialized.
        /// </summary>
        public override MemberInfo MemberInfo => _lazyContext.Value.MemberInfo;

        /// <summary>
        ///     The parent value in the object graph of the object being serialized.
        /// </summary>
        [Obsolete("Use ParentValue")]
        public override object Parent => _lazyContext.Value.Parent;
    }
}
