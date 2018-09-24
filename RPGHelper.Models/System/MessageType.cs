using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHelper.Models.System
{
    public sealed class MessageType
    {
        private readonly int _value;
        private readonly string _name;

        public static readonly MessageType Basic = new MessageType(0, "");
        public static readonly MessageType Success = new MessageType(1, "success");
        public static readonly MessageType Warning = new MessageType(2, "warning");
        public static readonly MessageType Error = new MessageType(3, "error");
        public static readonly MessageType Danger = new MessageType(4, "danger");

        private MessageType(int value, string name)
        {
            _value = value;
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
