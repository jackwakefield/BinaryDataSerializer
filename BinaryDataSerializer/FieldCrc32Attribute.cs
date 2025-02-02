﻿namespace BinaryDataSerialization
{
    /// <summary>
    ///     Specifies a 32-bit checksum for a member or object sub-graph.
    /// </summary>
    public sealed class FieldCrc32Attribute : FieldValueAttributeBase
    {
        private const uint DefaultPolynomial = 0xedb88320;
        private const uint DefaultInitialValue = uint.MaxValue;
        private const uint DefaultFinalXor = uint.MaxValue;

        /// <summary>
        ///     Initializes a new instance of the FieldCrc32 class.
        /// </summary>
        public FieldCrc32Attribute(string crcPath) : base(crcPath)
        {
        }

        /// <summary>
        ///     Gets or sets the generator polynomial for this checksum.  By default this is 0xedb88320.
        /// </summary>
        public uint Polynomial { get; set; } = DefaultPolynomial;

        /// <summary>
        ///     Gets or sets the initial value of the polynomial.  By default this is 0xffffffff.
        /// </summary>
        public uint InitialValue { get; set; } = DefaultInitialValue;

        /// <summary>
        ///     Gets or sets a flag indicating whether data should be reflected during computation.  By default this is true.
        /// </summary>
        public bool IsDataReflected { get; set; } = true;

        /// <summary>
        ///     Gets or sets a flag indicating whether the remainder should be reflected before final xor operation.  By default
        ///     this is true.
        /// </summary>
        public bool IsRemainderReflected { get; set; } = true;

        /// <summary>
        ///     Gets or sets a final xor value.  By default this value is 0xffffffff.
        /// </summary>
        public uint FinalXor { get; set; } = DefaultFinalXor;

        /// <summary>
        ///     This is called by the framework to indicate a new operation.
        /// </summary>
        /// <param name="context"></param>
        protected override object GetInitialState(BinaryDataSerializationContext context)
        {
            return new Crc32(Polynomial, InitialValue)
            {
                IsDataReflected = IsDataReflected,
                IsRemainderReflected = IsRemainderReflected,
                FinalXor = FinalXor
            };
        }

        /// <summary>
        ///     This is called one or more times by the framework to add data to the computation.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        protected override object GetUpdatedState(object state, byte[] buffer, int offset, int count)
        {
            var crc = (Crc32)state;
            crc.Compute(buffer, offset, count);
            return crc;
        }

        /// <summary>
        ///     This is called by the framework to retrieve the final value from computation.
        /// </summary>
        /// <returns></returns>
        protected override object GetFinalValue(object state)
        {
            var crc = (Crc32)state;
            return crc.ComputeFinal();
        }
    }
}
