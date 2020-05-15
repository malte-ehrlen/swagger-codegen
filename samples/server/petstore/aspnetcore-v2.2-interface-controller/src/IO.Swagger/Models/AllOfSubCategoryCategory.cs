/*
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AllOfSubCategoryCategory : Category, IEquatable<AllOfSubCategoryCategory>
    { 
        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [DataMember(Name="foo")]
        public bool? Foo { get; set; }

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [DataMember(Name="bar")]
        public int? Bar { get; set; }

        /// <summary>
        /// Gets or Sets Beer
        /// </summary>
        [DataMember(Name="beer")]
        public string Beer { get; set; }

        /// <summary>
        /// Gets or Sets Drunk
        /// </summary>
        [DataMember(Name="drunk")]
        public User Drunk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfSubCategoryCategory {\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Beer: ").Append(Beer).Append("\n");
            sb.Append("  Drunk: ").Append(Drunk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((AllOfSubCategoryCategory)obj);
        }

        /// <summary>
        /// Returns true if AllOfSubCategoryCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of AllOfSubCategoryCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfSubCategoryCategory other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Foo == other.Foo ||
                    Foo != null &&
                    Foo.Equals(other.Foo)
                ) && 
                (
                    Bar == other.Bar ||
                    Bar != null &&
                    Bar.Equals(other.Bar)
                ) && 
                (
                    Beer == other.Beer ||
                    Beer != null &&
                    Beer.Equals(other.Beer)
                ) && 
                (
                    Drunk == other.Drunk ||
                    Drunk != null &&
                    Drunk.Equals(other.Drunk)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Foo != null)
                    hashCode = hashCode * 59 + Foo.GetHashCode();
                    if (Bar != null)
                    hashCode = hashCode * 59 + Bar.GetHashCode();
                    if (Beer != null)
                    hashCode = hashCode * 59 + Beer.GetHashCode();
                    if (Drunk != null)
                    hashCode = hashCode * 59 + Drunk.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AllOfSubCategoryCategory left, AllOfSubCategoryCategory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AllOfSubCategoryCategory left, AllOfSubCategoryCategory right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
