using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;

namespace TodoTest.Data
{
    public class TodoModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime Date { get; set; }
        public string LocalTime { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Todo label is too long.")]
        public string Label { get; set; }
        [StringLength(200, ErrorMessage = "Description too long.")]
        public string Description { get; set; }
        [Required]
        public string Priority { get; set; }
        [Required]
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
    }
}
