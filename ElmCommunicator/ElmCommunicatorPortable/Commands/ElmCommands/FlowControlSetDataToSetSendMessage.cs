﻿// Copyright 2015 Tosho Toshev
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;

namespace ElmCommunicatorPortable.Commands.ElmCommands
{
    public class FlowControlSetDataToSetSendMessage : SendMessage
    {
        public FlowControlSetDataToSetSendMessage(string[] dataBytes)
        {
            if (dataBytes == null)
                throw new ArgumentNullException("dataBytes");

            if (dataBytes.Length < 1 && dataBytes.Length > 5)
                throw new ArgumentOutOfRangeException("dataBytes");

            Command = "AT FC SD";
            Data = string.Join("", dataBytes);
        }
    }
}