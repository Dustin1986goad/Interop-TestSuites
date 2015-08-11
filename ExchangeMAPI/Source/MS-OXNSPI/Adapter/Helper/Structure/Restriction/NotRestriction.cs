﻿//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXNSPI
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Protocols.TestSuites.Common;

    /// <summary>
    /// The NotRestriction class.
    /// </summary>
    public class NotRestriction : Restriction
    {
        /// <summary>
        /// Initializes a new instance of the NotRestriction class.
        /// </summary>
        public NotRestriction()
        {
            this.RestrictType = Restrictions.NotRestriction;
        }

        /// <summary>
        /// Gets or sets an array of restriction structures.
        /// </summary>
        public byte[] Restrict
        {
            get;
            set;
        }

        /// <summary>
        /// Deserialize the NotRestriction data.
        /// </summary>
        /// <param name="restrictionData">The restriction data.</param>
        public override void Deserialize(byte[] restrictionData)
        {
            int index = 0;
            this.RestrictType = (Restrictions)restrictionData[index];

            if (this.RestrictType != Restrictions.NotRestriction)
            {
                throw new ArgumentException("The restrict type is not NotRestriction type.");
            }

            index++;
        }

        /// <summary>
        /// Serialize the Restriction data.
        /// </summary>
        /// <returns>Format the type of Restriction data to byte array.</returns>
        public override byte[] Serialize()
        {
            List<byte> restrictionData = new List<byte>();

            restrictionData.Add((byte)this.RestrictType);
            restrictionData.AddRange(this.Restrict);

            return restrictionData.ToArray();
        }

        /// <summary>
        /// Get the size of the restriction data.
        /// </summary>
        /// <returns>Returns the size of restriction data.</returns>
        public override int Size()
        {
            int size = 0;
            size += sizeof(byte) + sizeof(uint);

            return size;
        }
    }
}