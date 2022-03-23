using System;
using Messages.Interfaces;

namespace Messages
{
    public class MessageStream : IMessage
    {
        public string Value { get; set; }
        public MessageStream(string text)
        {
            Value = text;
        }
        public MessageStream() { }
    }
}
