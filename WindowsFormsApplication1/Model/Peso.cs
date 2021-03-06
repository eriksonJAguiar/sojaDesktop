﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SojaApp.Model
{
    class Peso
    {
        [BsonId]
        public ObjectId _id {get; set;}

        [BsonElement("Atributo")]
        public String atributo { get; set; }

        [BsonElement("Peso")]
        public Int32 peso { get; set; }
    }
}
