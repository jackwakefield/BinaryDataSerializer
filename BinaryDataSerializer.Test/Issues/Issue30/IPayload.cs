﻿namespace BinaryDataSerialization.Test.Issues.Issue30
{
    public interface IPayload
    {
        PayloadType GetPayloadType();
        uint GetPayloadLength();
    }
}
