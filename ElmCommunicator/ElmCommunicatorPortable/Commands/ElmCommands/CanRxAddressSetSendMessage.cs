﻿using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class CanRxAddressSetSendMessage : CanRxAddressSendMessage
    {
        public CanRxAddressSetSendMessage(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException("address", "The address is empty.");

            if (address.Length != 3 && address.Length != 8)
                throw new ArgumentOutOfRangeException("address");

            Data = address;
        }
    }
}