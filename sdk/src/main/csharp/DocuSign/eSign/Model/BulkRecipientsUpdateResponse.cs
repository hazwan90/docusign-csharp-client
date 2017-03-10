/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BulkRecipientsUpdateResponse
    /// </summary>
    [DataContract]
    public partial class BulkRecipientsUpdateResponse :  IEquatable<BulkRecipientsUpdateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRecipientsUpdateResponse" /> class.
        /// </summary>
        /// <param name="Signer">Signer.</param>
        public BulkRecipientsUpdateResponse(Signer Signer = default(Signer))
        {
            this.Signer = Signer;
        }
        
        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name="signer", EmitDefaultValue=false)]
        public Signer Signer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkRecipientsUpdateResponse {\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BulkRecipientsUpdateResponse);
        }

        /// <summary>
        /// Returns true if BulkRecipientsUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkRecipientsUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkRecipientsUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Signer == other.Signer ||
                    this.Signer != null &&
                    this.Signer.Equals(other.Signer)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Signer != null)
                    hash = hash * 59 + this.Signer.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}