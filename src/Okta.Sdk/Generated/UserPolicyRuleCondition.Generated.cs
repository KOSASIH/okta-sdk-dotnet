// <copyright file="UserPolicyRuleCondition.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class UserPolicyRuleCondition : Resource, IUserPolicyRuleCondition
    {
        /// <inheritdoc/>
        public IList<string> Exclude 
        {
            get => GetArrayProperty<string>("exclude");
            set => this["exclude"] = value;
        }
        
        /// <inheritdoc/>
        public IInactivityPolicyRuleCondition Inactivity 
        {
            get => GetResourceProperty<InactivityPolicyRuleCondition>("inactivity");
            set => this["inactivity"] = value;
        }
        
        /// <inheritdoc/>
        public IList<string> Include 
        {
            get => GetArrayProperty<string>("include");
            set => this["include"] = value;
        }
        
        /// <inheritdoc/>
        public ILifecycleExpirationPolicyRuleCondition LifecycleExpiration 
        {
            get => GetResourceProperty<LifecycleExpirationPolicyRuleCondition>("lifecycleExpiration");
            set => this["lifecycleExpiration"] = value;
        }
        
        /// <inheritdoc/>
        public IPasswordExpirationPolicyRuleCondition PasswordExpiration 
        {
            get => GetResourceProperty<PasswordExpirationPolicyRuleCondition>("passwordExpiration");
            set => this["passwordExpiration"] = value;
        }
        
        /// <inheritdoc/>
        public IUserLifecycleAttributePolicyRuleCondition UserLifecycleAttribute 
        {
            get => GetResourceProperty<UserLifecycleAttributePolicyRuleCondition>("userLifecycleAttribute");
            set => this["userLifecycleAttribute"] = value;
        }
        
    }
}