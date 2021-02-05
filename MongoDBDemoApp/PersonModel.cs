using MongoDB.Bson.Serialization.Attributes;
using System;
using MongoDB.Bson;

namespace MongoDBDemoApp
{
    partial class Program
    {
        public class PersonModel
        {
            [BsonId]
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public AddressModel PrimaryAddress { get; set; }
            [BsonElement("DoB")]
            public DateTime DateOfBirth { get; set; }
        }
    }
}
