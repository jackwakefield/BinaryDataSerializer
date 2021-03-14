using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Issues.Issue140
{
    public interface IDomain
    {
        List<ILabel> Labels { get; }
        string Name { get; }
    }
}
