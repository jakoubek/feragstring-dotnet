using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feragstring
{
    internal class TitleInfo
    {

        private Message _message;
        private string? _printObjectName;
        private string? _titleName;
        private DateOnly? _publicationDate;
        private string? _countryCode;
        private string? _printObjectColor;

        public TitleInfo()
        {
            _message = new Message("2440", "!");
        }

        public string Message()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(PrintObjectName);
            sb.Append(TitleName);
            sb.Append(PublicationDate);
            sb.Append(CountryCode);
            sb.Append(PrintObjectColor);
            return _message.ToString(sb.ToString());
        }

        public string PrintObjectName
        {
            get
            {
                if (_printObjectName != null)
                {
                    return string.Format("+93{0:-12.12}", _printObjectName);
                }
                else
                {
                    return "";
                }
            }
            set { _printObjectName = value; }
        }

        public string TitleName
        {
            get
            {
                return string.Format("+40{0:-8.8}", _titleName);
            }
            set { _titleName = value; }
        }

        public string PublicationDate
        {
            get
            {
                if (_publicationDate.HasValue)
                {
                    return string.Format("+95{0:-6.6}", _publicationDate?.ToString("yyMMdd"));
                }
                else
                {
                    return "";
                }
            }
            set { _publicationDate = DateOnly.Parse(value); }
        }

        public string CountryCode
        {
            get
            {
                if (_countryCode != "")
                {
                    return string.Format("+97{0:-2.2}", _countryCode);
                }
                else
                {
                    return "";
                }
            }
            set { _countryCode = value; }
        }

        public string PrintObjectColor
        {
            get
            {
                if (_printObjectColor != "")
                {
                    return string.Format("+94{0:-8.8}", _printObjectColor);
                }
                else
                {
                    return "";
                }
            }
            set { _printObjectColor = value;  }
        }
    }
}
