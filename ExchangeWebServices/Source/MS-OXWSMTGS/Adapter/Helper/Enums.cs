//-----------------------------------------------------------------------
// Copyright (c) 2015 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXWSMTGS
{
    /// <summary>
    /// An enumeration that describes roles of a meeting. 
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// Represent the organizer of a meeting.
        /// </summary>
        Organizer,
        
        /// <summary>
        /// Represent the attendee of a meeting.
        /// </summary>
        Attendee
    }
}