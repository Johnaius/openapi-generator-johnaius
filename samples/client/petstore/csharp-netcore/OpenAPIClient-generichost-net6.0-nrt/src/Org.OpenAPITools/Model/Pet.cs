// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Pet
    /// </summary>
    public partial class Pet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        /// <param name="category">category</param>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="photoUrls">photoUrls</param>
        /// <param name="status">pet status in the store</param>
        /// <param name="tags">tags</param>
        [JsonConstructor]
        public Pet(Category category, long id, string name, List<string> photoUrls, StatusEnum status, List<Tag> tags)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException("id is a required property for Pet and cannot be null.");

            if (category == null)
                throw new ArgumentNullException("category is a required property for Pet and cannot be null.");

            if (name == null)
                throw new ArgumentNullException("name is a required property for Pet and cannot be null.");

            if (photoUrls == null)
                throw new ArgumentNullException("photoUrls is a required property for Pet and cannot be null.");

            if (tags == null)
                throw new ArgumentNullException("tags is a required property for Pet and cannot be null.");

            if (status == null)
                throw new ArgumentNullException("status is a required property for Pet and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Category = category;
            Id = id;
            Name = name;
            PhotoUrls = photoUrls;
            Status = status;
            Tags = tags;
        }

        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            Available = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            Pending = 2,

            /// <summary>
            /// Enum Sold for value: sold
            /// </summary>
            Sold = 3

        }

        /// <summary>
        /// Returns a StatusEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value == "available")
                return StatusEnum.Available;

            if (value == "pending")
                return StatusEnum.Pending;

            if (value == "sold")
                return StatusEnum.Sold;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Available)
                return "available";

            if (value == StatusEnum.Pending)
                return "pending";

            if (value == StatusEnum.Sold)
                return "sold";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// pet status in the store
        /// </summary>
        /// <value>pet status in the store</value>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonPropertyName("category")]
        public Category Category { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PhotoUrls
        /// </summary>
        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Pet {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhotoUrls: ").Append(PhotoUrls).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Pet
    /// </summary>
    public class PetJsonConverter : JsonConverter<Pet>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Pet Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Category category = default;
            long id = default;
            string name = default;
            List<string> photoUrls = default;
            Pet.StatusEnum status = default;
            List<Tag> tags = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "category":
                            category = JsonSerializer.Deserialize<Category>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "id":
                            id = utf8JsonReader.GetInt64();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "photoUrls":
                            photoUrls = JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "status":
                            string statusRawValue = utf8JsonReader.GetString();
                            status = Pet.StatusEnumFromString(statusRawValue);
                            break;
                        case "tags":
                            tags = JsonSerializer.Deserialize<List<Tag>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Pet(category, id, name, photoUrls, status, tags);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="pet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Pet pet, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("category");
            JsonSerializer.Serialize(writer, pet.Category, jsonSerializerOptions);
            writer.WriteNumber("id", pet.Id);
            writer.WriteString("name", pet.Name);
            writer.WritePropertyName("photoUrls");
            JsonSerializer.Serialize(writer, pet.PhotoUrls, jsonSerializerOptions);
            var statusRawValue = Pet.StatusEnumToJsonValue(pet.Status);
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            else
                writer.WriteNull("status");
            writer.WritePropertyName("tags");
            JsonSerializer.Serialize(writer, pet.Tags, jsonSerializerOptions);

            writer.WriteEndObject();
        }
    }
}
