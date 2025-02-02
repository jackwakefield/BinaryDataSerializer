﻿using BinaryDataSerialization;

namespace BinaryDataSerializer.Editor.Test
{
    public class PngTextChunk : PngChunk
    {
        [SerializeAs(SerializedType.TerminatedString)]
        public string Keyword { get; set; }

        [SerializeAs(SerializedType.SizedString)]
        public string Value { get; set; }
    }
}
