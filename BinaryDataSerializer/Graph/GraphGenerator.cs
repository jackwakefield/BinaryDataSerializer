using System;
using System.Collections.Concurrent;
using BinaryDataSerialization.Graph.TypeGraph;

namespace BinaryDataSerialization.Graph
{
    internal class GraphGenerator
    {
        private readonly ConcurrentDictionary<Type, RootTypeNode> _graphCache =
            new ConcurrentDictionary<Type, RootTypeNode>();

        public RootTypeNode GenerateGraph(Type valueType)
        {
            return _graphCache.GetOrAdd(valueType, type => new RootTypeNode(type));
        }
    }
}
