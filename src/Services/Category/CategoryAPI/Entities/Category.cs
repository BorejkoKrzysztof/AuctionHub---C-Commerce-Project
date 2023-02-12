using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CategoryAPI.Entities
{
    public class Category
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonRequired]
        public string Id { get; set; }

        [BsonElement("Name")]
        [BsonRepresentation(BsonType.String, AllowTruncation = true)]
        [MaxLength(75)]
        [MinLength(2)]
        [BsonRequired]        
        public string Name { get; set; }

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [BsonRepresentation(BsonType.ObjectId)]
        public string? Parent_Id { get; set; }
    }
}
