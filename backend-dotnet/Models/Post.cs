using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models {
    public class Post {

        [BsonId]
        [BsonRepresentation (BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement ("title")]
        public string Title { get; set; }

        [BsonElement ("description")]
        public string Description { get; set; }

        [BsonElement ("timestamp")]
        public BsonTimestamp timestamp { get; set; }

    }
}