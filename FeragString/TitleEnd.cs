using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feragstring
{
    internal class TitleEnd
    {

        private Message _message;
        private string? _titleName;

        public TitleEnd()
        {
            _message = new Message("2441", "!");
        }

        public string Message()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(TitleName);
            return _message.ToString(sb.ToString());
        }

        public string TitleName
        {
            get
            {
                return string.Format("+40{0:-8.8}", _titleName);
            }
            set { _titleName = value; }
        }

    }
}
