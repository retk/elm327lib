﻿using System;
using System.Globalization;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class MemoryOnOffSetSendMessage : SendMessage
    {
        public MemoryOnOffSetSendMessage(bool state)
        {
            Command = "AT M";
            Data = Convert.ToInt32(state).ToString(CultureInfo.InvariantCulture);
        }
    }
}