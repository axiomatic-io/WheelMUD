﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PlayerIpAddressRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    /// <summary>Represents a single PlayerIPAddress row in the PlayerIPAddress table.</summary>
    public partial class PlayerIpAddressRecord
    {
        public virtual long ID { get; set; }
        public virtual long PlayerID { get; set; }
        public virtual string IPAddress { get; set; }
    }
}