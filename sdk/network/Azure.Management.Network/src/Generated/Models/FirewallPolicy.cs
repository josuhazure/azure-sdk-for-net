// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> FirewallPolicy Resource. </summary>
    public partial class FirewallPolicy : Resource
    {
        /// <summary> Initializes a new instance of FirewallPolicy. </summary>
        public FirewallPolicy()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The identity of the firewall policy. </param>
        /// <param name="ruleGroups"> List of references to FirewallPolicyRuleGroups. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy resource. </param>
        /// <param name="basePolicy"> The parent firewall policy from which rules are inherited. </param>
        /// <param name="firewalls"> List of references to Azure Firewalls that this Firewall Policy is associated with. </param>
        /// <param name="childPolicies"> List of references to Child Firewall Policies. </param>
        /// <param name="threatIntelMode"> The operation mode for Threat Intelligence. </param>
        /// <param name="threatIntelWhitelist"> ThreatIntel Whitelist for Firewall Policy. </param>
        /// <param name="intrusionSystemMode"> The operation mode for Intrusion system. </param>
        /// <param name="transportSecurity"> TLS Configuration definition. </param>
        internal FirewallPolicy(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, ManagedServiceIdentity identity, IList<SubResource> ruleGroups, ProvisioningState? provisioningState, SubResource basePolicy, IList<SubResource> firewalls, IList<SubResource> childPolicies, AzureFirewallThreatIntelMode? threatIntelMode, FirewallPolicyThreatIntelWhitelist threatIntelWhitelist, FirewallPolicyIntrusionSystemMode? intrusionSystemMode, FirewallPolicyTransportSecurity transportSecurity) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Identity = identity;
            RuleGroups = ruleGroups;
            ProvisioningState = provisioningState;
            BasePolicy = basePolicy;
            Firewalls = firewalls;
            ChildPolicies = childPolicies;
            ThreatIntelMode = threatIntelMode;
            ThreatIntelWhitelist = threatIntelWhitelist;
            IntrusionSystemMode = intrusionSystemMode;
            TransportSecurity = transportSecurity;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The identity of the firewall policy. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> List of references to FirewallPolicyRuleGroups. </summary>
        public IList<SubResource> RuleGroups { get; }
        /// <summary> The provisioning state of the firewall policy resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The parent firewall policy from which rules are inherited. </summary>
        public SubResource BasePolicy { get; set; }
        /// <summary> List of references to Azure Firewalls that this Firewall Policy is associated with. </summary>
        public IList<SubResource> Firewalls { get; }
        /// <summary> List of references to Child Firewall Policies. </summary>
        public IList<SubResource> ChildPolicies { get; }
        /// <summary> The operation mode for Threat Intelligence. </summary>
        public AzureFirewallThreatIntelMode? ThreatIntelMode { get; set; }
        /// <summary> ThreatIntel Whitelist for Firewall Policy. </summary>
        public FirewallPolicyThreatIntelWhitelist ThreatIntelWhitelist { get; set; }
        /// <summary> The operation mode for Intrusion system. </summary>
        public FirewallPolicyIntrusionSystemMode? IntrusionSystemMode { get; set; }
        /// <summary> TLS Configuration definition. </summary>
        public FirewallPolicyTransportSecurity TransportSecurity { get; set; }
    }
}