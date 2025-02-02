using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace BinaryDataSerialization.Graph.TypeGraph
{
    internal abstract class ContainerTypeNode : TypeNode
    {
        protected const BindingFlags ConstructorBindingFlags = BindingFlags.Instance | BindingFlags.Public;

        protected ContainerTypeNode(TypeNode parent, Type type)
            : base(parent, type)
        {
        }

        protected ContainerTypeNode(TypeNode parent, Type parentType, MemberInfo memberInfo, Type subType = null)
            : base(parent, parentType, memberInfo, subType)
        {
        }

        protected TypeNode GenerateChild(Type type)
        {
            try
            {
                ThrowOnBadType(type);

                var nodeType = GetNodeType(type);

                var child = (TypeNode)Activator.CreateInstance(nodeType, this, type);
                return child;
            }
            catch (Exception exception)
            {
                var message = $"There was an error reflecting type '{type}'";
                throw new InvalidOperationException(message, exception);
            }
        }

        protected TypeNode GenerateChild(Type parentType, MemberInfo memberInfo)
        {
            var memberType = GetMemberType(memberInfo);

            try
            {
                ThrowOnBadType(memberType);

                var nodeType = GetNodeType(memberType);

                return (TypeNode)Activator.CreateInstance(nodeType, this, parentType, memberInfo);
            }
            catch (Exception exception)
            {
                var message = $"There was an error reflecting member '{memberInfo.Name}'";
                throw new InvalidOperationException(message, exception);
            }
        }

        protected static Type GetMemberType(MemberInfo memberInfo)
        {
            switch (memberInfo)
            {
                case PropertyInfo propertyInfo:
                    return propertyInfo.PropertyType;

                case FieldInfo fieldInfo:
                    return fieldInfo.FieldType;
            }

            throw new NotSupportedException($"{memberInfo.GetType().Name} not supported");
        }

        // ReSharper disable UnusedParameter.Local
        private static void ThrowOnBadType(Type type)
        {
            if (typeof(IDictionary).IsAssignableFrom(type))
            {
                throw new InvalidOperationException("Cannot serialize objects that implement IDictionary.");
            }
        }
        // ReSharper restore UnusedParameter.Local

        private static Type GetNodeType(Type type)
        {
            var nullableType = Nullable.GetUnderlyingType(type);

            var effectiveType = nullableType ?? type;

            if (effectiveType.GetTypeInfo().IsEnum)
            {
                return typeof(EnumTypeNode);
            }

            if (IsValueType(effectiveType))
            {
                return typeof(ValueTypeNode);
            }

            if (type.IsArray)
            {
                return typeof(ArrayTypeNode);
            }

            if (typeof(IList).IsAssignableFrom(type))
            {
                return typeof(ListTypeNode);
            }

            if (typeof(Stream).IsAssignableFrom(type))
            {
                return typeof(StreamTypeNode);
            }

            if (typeof(IBinaryDataSerializable).IsAssignableFrom(type))
            {
                return typeof(CustomTypeNode);
            }

            if (type == typeof(object))
            {
                return typeof(UnknownTypeNode);
            }

            return typeof(ObjectTypeNode);
        }
    }
}
