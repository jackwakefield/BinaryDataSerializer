﻿using System.Collections.Generic;

namespace BinaryDataSerialization.Test.Issues.Issue12
{
    public class CatChunk : Chunk
    {
        [FieldOrder(0)]
        [FieldLength(4)]
        public string TypeId { get; set; }

        [FieldOrder(1)]
        public List<ChunkContainer> Chunks { get; set; }
    }
}
