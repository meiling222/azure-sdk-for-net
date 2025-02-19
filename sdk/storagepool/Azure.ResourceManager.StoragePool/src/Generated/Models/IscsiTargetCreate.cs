// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Payload for iSCSI Target create or update requests. </summary>
    public partial class IscsiTargetCreate : Resource
    {
        /// <summary> Initializes a new instance of IscsiTargetCreate. </summary>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        public IscsiTargetCreate(IscsiTargetAclMode aclMode)
        {
            ManagedByExtended = new ChangeTrackingList<string>();
            AclMode = aclMode;
            StaticAcls = new ChangeTrackingList<Acl>();
            Luns = new ChangeTrackingList<IscsiLun>();
        }

        /// <summary> Initializes a new instance of IscsiTargetCreate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: &quot;iqn.2005-03.org.iscsi:server&quot;. </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        internal IscsiTargetCreate(ResourceIdentifier id, string name, ResourceType type, string managedBy, IList<string> managedByExtended, IscsiTargetAclMode aclMode, string targetIqn, IList<Acl> staticAcls, IList<IscsiLun> luns) : base(id, name, type)
        {
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            AclMode = aclMode;
            TargetIqn = targetIqn;
            StaticAcls = staticAcls;
            Luns = luns;
        }

        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Mode for Target connectivity. </summary>
        public IscsiTargetAclMode AclMode { get; set; }
        /// <summary> iSCSI Target IQN (iSCSI Qualified Name); example: &quot;iqn.2005-03.org.iscsi:server&quot;. </summary>
        public string TargetIqn { get; set; }
        /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
        public IList<Acl> StaticAcls { get; }
        /// <summary> List of LUNs to be exposed through iSCSI Target. </summary>
        public IList<IscsiLun> Luns { get; }
    }
}
