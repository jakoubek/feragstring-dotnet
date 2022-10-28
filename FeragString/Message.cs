using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feragstring
{
    internal class Message
    {
        private string _messageStart;
        private string _messageEnd;

        public Message(string messageStart, string messageEnd)
        {
            _messageStart = messageStart;
            _messageEnd = messageEnd;
        }

        public string ToString(string payload)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_messageStart);
            sb.Append(payload);
            sb.AppendLine(_messageEnd);
            return sb.ToString();
        }
    }
}
