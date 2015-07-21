// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.BackupServices.Models
{
    /// <summary>
    /// The definition of MarsContainerProperties.
    /// </summary>
    public partial class MarsContainerProperties
    {
        private bool _canReRegister;
        
        /// <summary>
        /// Optional. MARS Container Re-registrablity Flag
        /// </summary>
        public bool CanReRegister
        {
            get { return this._canReRegister; }
            set { this._canReRegister = value; }
        }
        
        private long _containerId;
        
        /// <summary>
        /// Optional. MARS Container ID
        /// </summary>
        public long ContainerId
        {
            get { return this._containerId; }
            set { this._containerId = value; }
        }
        
        private Guid _containerStampId;
        
        /// <summary>
        /// Optional. MARS Container Stamp ID
        /// </summary>
        public Guid ContainerStampId
        {
            get { return this._containerStampId; }
            set { this._containerStampId = value; }
        }
        
        private string _containerStampUri;
        
        /// <summary>
        /// Optional. MARS Container Stamp URI
        /// </summary>
        public string ContainerStampUri
        {
            get { return this._containerStampUri; }
            set { this._containerStampUri = value; }
        }
        
        private string _customerType;
        
        /// <summary>
        /// Optional. MARS Container Customer Type
        /// </summary>
        public string CustomerType
        {
            get { return this._customerType; }
            set { this._customerType = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. MARS Container Friendly Name
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MarsContainerProperties class.
        /// </summary>
        public MarsContainerProperties()
        {
        }
    }
}
