// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the patch schedule operation.
    /// </summary>
    public partial class SchedulePatchParameters
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the schedule.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private SchedulePatchProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the list of schedule properties.
        /// </summary>
        public SchedulePatchProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulePatchParameters class.
        /// </summary>
        public SchedulePatchParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SchedulePatchParameters class
        /// with required arguments.
        /// </summary>
        public SchedulePatchParameters(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
