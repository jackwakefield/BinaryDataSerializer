﻿using System.Collections.Generic;
using System.IO;

namespace BinaryDataSerialization.Test.Custom
{
    public class CustomListClass : List<string>, IBinaryDataSerializable
    {
        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            foreach (var item in this)
            {
                var data = System.Text.Encoding.UTF8.GetBytes(item);
                stream.WriteByte((byte)data.Length);
                stream.Write(data, 0, data.Length);
            }
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            while (stream.Position < stream.Length)
            {
                var length = stream.ReadByte();
                var data = new byte[length];
                stream.Read(data, 0, data.Length);
                var item = System.Text.Encoding.UTF8.GetString(data);
                Add(item);
            }
        }
    }
}
