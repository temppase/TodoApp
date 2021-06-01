using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoTest.Data
{
    public class TodoModel
    {
        public string Table = "ToDoTable";
        [BsonId]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
