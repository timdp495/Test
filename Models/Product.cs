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
    public partial class Product :  IEquatable<Product>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="ProductId">Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles..</param>
        /// <param name="Description">Description of product..</param>
        /// <param name="DisplayName">Display name of product..</param>
        /// <param name="Capacity">Capacity of product. For example, 4 people..</param>
        /// <param name="Image">Image URL representing the product..</param>
        public Product(string ProductId = null, string Description = null, string DisplayName = null, string Capacity = null, string Image = null)
        {
            this.ProductId = ProductId;
            this.Description = Description;
            this.DisplayName = DisplayName;
            this.Capacity = Capacity;
            this.Image = Image;
            
        }

        /// <summary>
        /// Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
        /// </summary>
        /// <value>Unique identifier representing a specific product for a given latitude & longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.</value>
        [DataMember(Name="product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Description of product.
        /// </summary>
        /// <value>Description of product.</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Display name of product.
        /// </summary>
        /// <value>Display name of product.</value>
        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Capacity of product. For example, 4 people.
        /// </summary>
        /// <value>Capacity of product. For example, 4 people.</value>
        [DataMember(Name="capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Image URL representing the product.
        /// </summary>
        /// <value>Image URL representing the product.</value>
        [DataMember(Name="image")]
        public string Image { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return Equals((Product)obj);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="other">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                    if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                    if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                    if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                    if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();
                    if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Product left, Product right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Product left, Product right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
