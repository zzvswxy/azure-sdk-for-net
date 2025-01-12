// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Network Rule Set Properties of IotHub. </summary>
    public partial class NetworkRuleSetProperties
    {
        /// <summary> Initializes a new instance of NetworkRuleSetProperties. </summary>
        /// <param name="applyToBuiltInEventHubEndpoint"> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </param>
        /// <param name="ipRules"> List of IP Rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipRules"/> is null. </exception>
        public NetworkRuleSetProperties(bool applyToBuiltInEventHubEndpoint, IEnumerable<NetworkRuleSetIPRule> ipRules)
        {
            if (ipRules == null)
            {
                throw new ArgumentNullException(nameof(ipRules));
            }

            ApplyToBuiltInEventHubEndpoint = applyToBuiltInEventHubEndpoint;
            IPRules = ipRules.ToList();
        }

        /// <summary> Initializes a new instance of NetworkRuleSetProperties. </summary>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="applyToBuiltInEventHubEndpoint"> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </param>
        /// <param name="ipRules"> List of IP Rules. </param>
        internal NetworkRuleSetProperties(DefaultAction? defaultAction, bool applyToBuiltInEventHubEndpoint, IList<NetworkRuleSetIPRule> ipRules)
        {
            DefaultAction = defaultAction;
            ApplyToBuiltInEventHubEndpoint = applyToBuiltInEventHubEndpoint;
            IPRules = ipRules;
        }

        /// <summary> Default Action for Network Rule Set. </summary>
        public DefaultAction? DefaultAction { get; set; }
        /// <summary> If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub. </summary>
        public bool ApplyToBuiltInEventHubEndpoint { get; set; }
        /// <summary> List of IP Rules. </summary>
        public IList<NetworkRuleSetIPRule> IPRules { get; }
    }
}
