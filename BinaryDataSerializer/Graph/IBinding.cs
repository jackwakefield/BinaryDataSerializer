using System;
using BinaryDataSerialization.Graph.ValueGraph;

namespace BinaryDataSerialization.Graph
{
    internal interface IBinding
    {
        bool IsConst { get; }
        object ConstValue { get; }
        object GetValue(ValueNode target);
        void Bind(ValueNode target, Func<object> callback);
    }
}
