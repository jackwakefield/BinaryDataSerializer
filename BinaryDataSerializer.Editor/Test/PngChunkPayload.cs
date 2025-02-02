﻿using BinaryDataSerialization;

namespace BinaryDataSerializer.Editor.Test
{
    public class PngChunkPayload
    {
        [FieldOrder(0)]
        [FieldLength(4)]
        public string ChunkType { get; set; }

        [FieldOrder(1)]
        [FieldLength("Length", RelativeSourceMode = RelativeSourceMode.FindAncestor, AncestorLevel = 2)]
        [Subtype("ChunkType", "IHDR", typeof(PngImageHeaderChunk))]
        [Subtype("ChunkType", "PLTE", typeof(PngPaletteChunk))]
        [Subtype("ChunkType", "IDAT", typeof(PngImageDataChunk))]
        [Subtype("ChunkType", "tEXt", typeof(PngTextChunk))]
        [Subtype("ChunkType", "iTxt", typeof(PngInternationalTextChunk))]
        [SubtypeDefault(typeof(PngUnknownChunk))]
        public PngChunk Chunk { get; set; }
    }
}
