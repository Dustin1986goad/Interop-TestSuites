//-----------------------------------------------------------------------
// Copyright (c) 2014 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXCFXICS
{
    /// <summary>
    /// The MessageProperties
    /// </summary>
    public enum MessageProperties : uint
    {
        /// <summary>
        /// The PidTagMessageRecipients
        /// </summary>
        PidTagMessageRecipients = 0x0e12000d,

        /// <summary>
        /// The PidTagMessageAttachments
        /// </summary>
        PidTagMessageAttachments = 0x0e13000d
    }
}