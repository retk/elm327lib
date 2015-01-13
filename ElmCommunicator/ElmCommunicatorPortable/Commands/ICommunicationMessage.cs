﻿namespace ElmCommunicator.Commands
{
    /// <summary>
    ///     A communication message interfacewith standard COM message properties.
    /// </summary>
    public interface ICommunicationMessage
    {
        string Command { get; set; }
        string Data { get; set; }

        string StartTermination { get; set; }

        string EndTermination { get; set; }
    }
}