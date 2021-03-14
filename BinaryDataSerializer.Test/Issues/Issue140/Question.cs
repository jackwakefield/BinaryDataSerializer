using BinaryDataSerialization.Test.Issues.Issue139;

namespace BinaryDataSerialization.Test.Issues.Issue140
{
    public class Question : IQuestion
    {
        [FieldOrder(0)]
        [SubtypeDefault(typeof(Domain))] //Check Issue #139 
        public IDomain Domain { get; set; }
    }
}
