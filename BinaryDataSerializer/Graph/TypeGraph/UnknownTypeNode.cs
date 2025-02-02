﻿using System;
using System.Reflection;
using BinaryDataSerialization.Graph.ValueGraph;

namespace BinaryDataSerialization.Graph.TypeGraph
{
    internal class UnknownTypeNode : ObjectTypeNode
    {
        public UnknownTypeNode(TypeNode parent, Type type) : base(parent, type)
        {
        }

        public UnknownTypeNode(TypeNode parent, Type parentType, MemberInfo memberInfo) : base(parent, parentType,
            memberInfo)
        {
        }

        internal override ValueNode CreateSerializerOverride(ValueNode parent)
        {
            return new UnknownValueNode(parent, Name, this);
        }
    }
}
