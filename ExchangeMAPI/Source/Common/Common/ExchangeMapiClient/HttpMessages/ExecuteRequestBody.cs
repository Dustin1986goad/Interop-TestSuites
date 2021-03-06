namespace Microsoft.Protocols.TestSuites.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A class indicates the Execute request type request body.
    /// </summary>
    public class ExecuteRequestBody : MailboxRequestBodyBase
    {
        /// <summary>
        /// Gets or sets a set of flags that specify to the server how to build the ROP responses in the RopBuffer field of the Execute request type success response body.
        /// </summary>
        public uint Flags { get; set; }

        /// <summary>
        /// Gets or sets an unsigned integer that specifies the size, in bytes, of the RopBuffer field.
        /// </summary>
        public uint RopBufferSize { get; set; }

        /// <summary>
        /// Gets or sets an array of bytes that constitute the ROP requests payload. 
        /// </summary>
        public byte[] RopBuffer { get; set; }

        /// <summary>
        /// Gets or sets an unsigned integer that specifies the maximum size for the RopBuffer field of the Execute request type success response body.
        /// </summary>
        public uint MaxRopOut { get; set; }

        /// <summary>
        /// Serialize the instance to byte array.
        /// </summary>
        /// <returns>The serialized data to be returned.</returns>
        public override byte[] Serialize()
        {
            List<byte> rawData = new List<byte>();

            rawData.AddRange(BitConverter.GetBytes(this.Flags));
            rawData.AddRange(BitConverter.GetBytes(this.RopBufferSize));
            rawData.AddRange(this.RopBuffer);
            rawData.AddRange(BitConverter.GetBytes(this.MaxRopOut));
            rawData.AddRange(BitConverter.GetBytes(this.AuxiliaryBufferSize));
            rawData.AddRange(this.AuxiliaryBuffer);

            return rawData.ToArray();
        }
    }
}