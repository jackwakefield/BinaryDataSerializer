﻿namespace BinaryDataSerialization
{
    /// <summary>
    ///     Specifies a 16-bit checksum for a member or object subgraph.
    /// </summary>
    public sealed class FieldCrc16Attribute : FieldValueAttributeBase
    {
        private const ushort DefaultPolynomial = 0x1021;
        private const ushort DefaultInitialValue = ushort.MaxValue;

        /// <summary>
        ///     Initializes a new instance of the FieldCrc16 class.
        /// </summary>
        public FieldCrc16Attribute(string crcPath) : base(crcPath)
        {
        }

        /// <summary>
        ///     Gets or sets the generator polynomial for this checksum.  By default this is the CCITT polynomial (0x1021).
        /// </summary>
        public ushort Polynomial { get; set; } = DefaultPolynomial;

        /// <summary>
        ///     Gets or sets the initial value of the polynomial.  By default this is 0xffff.
        /// </summary>
        public ushort InitialValue { get; set; } = DefaultInitialValue;

        /// <summary>
        ///     Gets or sets a flag indicating whether data should be reflected during computation.  By default this is false.
        /// </summary>
        public bool IsDataReflected { get; set; } = false;

        /// <summary>
        ///     Gets or sets a flag indicating whether the remainder should be reflected before final xor operation.  By default
        ///     this is false.
        /// </summary>
        public bool IsRemainderReflected { get; set; } = false;

        /// <summary>
        ///     Gets or sets a final xor value.  By default this value is zero.
        /// </summary>
        public ushort FinalXor { get; set; } = 0;

        /// <summary>
        ///     This is called by the framework to indicate a new operation.
        /// </summary>
        /// <param name="context"></param>
        protected override object GetInitialState(BinaryDataSerializationContext context)
        {
            return new Crc16(Polynomial, InitialValue)
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
            var crc = (Crc16)state;
            crc.Compute(buffer, offset, count);
            return state;
        }

        /// <summary>
        ///     This is called by the framework to retrieve the final value from computation.
        /// </summary>
        /// <returns></returns>
        protected override object GetFinalValue(object state)
        {
            var crc = (Crc16)state;
            return crc.ComputeFinal();
        }
    }
}
