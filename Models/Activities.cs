/*
 * Product API
 *
 * Move your app forward with the Product API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Activities :  IEquatable<Activities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activities" /> class.
        /// </summary>
        /// <param name="Offset">Position in pagination..</param>
        /// <param name="Limit">Number of items to retrieve (100 max)..</param>
        /// <param name="Count">Total number of items available..</param>
        /// <param name="History">History.</param>
        public Activities(int? Offset = null, int? Limit = null, int? Count = null, List<Activity> History = null)
        {
            this.Offset = Offset;
            this.Limit = Limit;
            this.Count = Count;
            this.History = History;
            
        }

        /// <summary>
        /// Position in pagination.
        /// </summary>
        /// <value>Position in pagination.</value>
        [DataMember(Name="offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Number of items to retrieve (100 max).
        /// </summary>
        /// <value>Number of items to retrieve (100 max).</value>
        [DataMember(Name="limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Total number of items available.
        /// </summary>
        /// <value>Total number of items available.</value>
        [DataMember(Name="count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history")]
        public List<Activity> History { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activities {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Activities)obj);
        }

        /// <summary>
        /// Returns true if Activities instances are equal
        /// </summary>
        /// <param name="other">Instance of Activities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activities other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.History == other.History ||
                    this.History != null &&
                    this.History.SequenceEqual(other.History)
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
                    if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                    if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                    if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                    if (this.History != null)
                    hash = hash * 59 + this.History.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Activities left, Activities right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Activities left, Activities right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
