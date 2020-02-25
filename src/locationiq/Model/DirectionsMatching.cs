/* 
 * LocationIQ
 *
 * LocationIQ provides flexible enterprise-grade location based solutions. We work with developers, startups and enterprises worldwide serving billions of requests everyday. This page provides an overview of the technical aspects of our API and will help you get started.
 *
 * The version of the OpenAPI document: 1.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = locationiq.Client.OpenAPIDateConverter;

namespace locationiq.Model
{
    /// <summary>
    /// DirectionsMatching
    /// </summary>
    [DataContract]
    public partial class DirectionsMatching :  IEquatable<DirectionsMatching>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectionsMatching" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="tracepoints">tracepoints.</param>
        /// <param name="matchings">matchings.</param>
        public DirectionsMatching(string code = default(string), List<Object> tracepoints = default(List<Object>), List<Object> matchings = default(List<Object>))
        {
            this.Code = code;
            this.Tracepoints = tracepoints;
            this.Matchings = matchings;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Tracepoints
        /// </summary>
        [DataMember(Name="tracepoints", EmitDefaultValue=false)]
        public List<Object> Tracepoints { get; set; }

        /// <summary>
        /// Gets or Sets Matchings
        /// </summary>
        [DataMember(Name="matchings", EmitDefaultValue=false)]
        public List<Object> Matchings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectionsMatching {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Tracepoints: ").Append(Tracepoints).Append("\n");
            sb.Append("  Matchings: ").Append(Matchings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirectionsMatching);
        }

        /// <summary>
        /// Returns true if DirectionsMatching instances are equal
        /// </summary>
        /// <param name="input">Instance of DirectionsMatching to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectionsMatching input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Tracepoints == input.Tracepoints ||
                    this.Tracepoints != null &&
                    input.Tracepoints != null &&
                    this.Tracepoints.SequenceEqual(input.Tracepoints)
                ) && 
                (
                    this.Matchings == input.Matchings ||
                    this.Matchings != null &&
                    input.Matchings != null &&
                    this.Matchings.SequenceEqual(input.Matchings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Tracepoints != null)
                    hashCode = hashCode * 59 + this.Tracepoints.GetHashCode();
                if (this.Matchings != null)
                    hashCode = hashCode * 59 + this.Matchings.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}