using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHelper.Models.System
{
    public class MessageTypeDto
    {
        public static string Name = "Message";

        public string Message { get; set; }
        public MessageType Type { get; set; }

        public MessageTypeDto(string message, MessageType type)
        {
            Message = message;
            Type = type;
        }

        public MessageTypeDto()
        {
            Message = string.Empty;
            Type = MessageType.Success;
        }
    }
}
