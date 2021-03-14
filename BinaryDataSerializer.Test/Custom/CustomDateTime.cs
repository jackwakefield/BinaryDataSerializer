﻿using System;
using System.IO;

namespace BinaryDataSerialization.Test.Custom
{
    public class CustomDateTime : IBinaryDataSerializable
    {
        [Ignore]
        public DateTime Value;

        public void Serialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var writer = new BinaryWriter(stream);
            writer.Write((ushort)Value.Year);
            writer.Write((byte)Value.Month);
            writer.Write((byte)Value.Day);
            writer.Write((byte)Value.Hour);
            writer.Write((byte)Value.Minute);
            writer.Write((byte)Value.Second);
            writer.Write((ushort)Value.Millisecond);
        }

        public void Deserialize(Stream stream, BinaryDataSerialization.Endianness endianness, BinaryDataSerializationContext serializationContext)
        {
            var reader = new BinaryReader(stream);
            var year = reader.ReadUInt16();
            var month = reader.ReadByte();
            var day = reader.ReadByte();
            var hour = reader.ReadByte();
            var minute = reader.ReadByte();
            var second = reader.ReadByte();
            var ms = reader.ReadUInt16();

            Value = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Local).AddMilliseconds(ms);
        }
    }
}
