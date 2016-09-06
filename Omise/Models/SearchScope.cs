﻿using System.Runtime.Serialization;

namespace Omise.Models {
    public enum SearchScope {
        [EnumMember(Value = null)]
        Unspecified,
        [EnumMember(Value = "dispute")]
        Dispute,
        [EnumMember(Value = "charge")]
        Charge,
        [EnumMember(Value = "customer")]
        Customer,
        [EnumMember(Value = "recipient")]
        Recipient,
    }
}

