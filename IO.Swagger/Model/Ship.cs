/* 
 * rpbdrgr
 *
 * rpbdrgr
 *
 * OpenAPI spec version: 1.0
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Ship
    /// </summary>
    [DataContract]
    public partial class Ship :  IEquatable<Ship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ship" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="currentcruise">currentcruise.</param>
        /// <param name="carrycapacity">carrycapacity.</param>
        /// <param name="homeport">homeport.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="location">location.</param>
        /// <param name="overhaulstartdate">overhaulstartdate.</param>
        public Ship(long? id = default(long?), string name = default(string), long? currentcruise = default(long?), float? carrycapacity = default(float?), long? homeport = default(long?), long? purpose = default(long?), List<float?> location = default(List<float?>), string overhaulstartdate = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Currentcruise = currentcruise;
            this.Carrycapacity = carrycapacity;
            this.Homeport = homeport;
            this.Purpose = purpose;
            this.Location = location;
            this.Overhaulstartdate = overhaulstartdate;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Currentcruise
        /// </summary>
        [DataMember(Name="currentcruise", EmitDefaultValue=false)]
        public long? Currentcruise { get; set; }

        /// <summary>
        /// Gets or Sets Carrycapacity
        /// </summary>
        [DataMember(Name="carrycapacity", EmitDefaultValue=false)]
        public float? Carrycapacity { get; set; }

        /// <summary>
        /// Gets or Sets Homeport
        /// </summary>
        [DataMember(Name="homeport", EmitDefaultValue=false)]
        public long? Homeport { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public long? Purpose { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public List<float?> Location { get; set; }

        /// <summary>
        /// Gets or Sets Overhaulstartdate
        /// </summary>
        [DataMember(Name="overhaulstartdate", EmitDefaultValue=false)]
        public string Overhaulstartdate { get; set; }

        public Port Port
        {
            get => default;
            set
            {
            }
        }

        public ShipPurpose ShipPurpose
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ship {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currentcruise: ").Append(Currentcruise).Append("\n");
            sb.Append("  Carrycapacity: ").Append(Carrycapacity).Append("\n");
            sb.Append("  Homeport: ").Append(Homeport).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Overhaulstartdate: ").Append(Overhaulstartdate).Append("\n");
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
            return this.Equals(input as Ship);
        }

        /// <summary>
        /// Returns true if Ship instances are equal
        /// </summary>
        /// <param name="input">Instance of Ship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ship input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Currentcruise == input.Currentcruise ||
                    (this.Currentcruise != null &&
                    this.Currentcruise.Equals(input.Currentcruise))
                ) && 
                (
                    this.Carrycapacity == input.Carrycapacity ||
                    (this.Carrycapacity != null &&
                    this.Carrycapacity.Equals(input.Carrycapacity))
                ) && 
                (
                    this.Homeport == input.Homeport ||
                    (this.Homeport != null &&
                    this.Homeport.Equals(input.Homeport))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.Overhaulstartdate == input.Overhaulstartdate ||
                    (this.Overhaulstartdate != null &&
                    this.Overhaulstartdate.Equals(input.Overhaulstartdate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Currentcruise != null)
                    hashCode = hashCode * 59 + this.Currentcruise.GetHashCode();
                if (this.Carrycapacity != null)
                    hashCode = hashCode * 59 + this.Carrycapacity.GetHashCode();
                if (this.Homeport != null)
                    hashCode = hashCode * 59 + this.Homeport.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Overhaulstartdate != null)
                    hashCode = hashCode * 59 + this.Overhaulstartdate.GetHashCode();
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
