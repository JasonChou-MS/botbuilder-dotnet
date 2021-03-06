﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Cognitive.LUIS.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;

    /// <summary>
    /// Child entity in Luis composite entity.
    /// </summary>
    public partial class CompositeChild
    {
        /// <summary>
        /// Initializes a new instance of the CompositeChild class.
        /// </summary>
        public CompositeChild()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CompositeChild class.
        /// </summary>
        public CompositeChild(string type, string value)
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Type of child entity.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Value extracted by Luis.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }

            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
