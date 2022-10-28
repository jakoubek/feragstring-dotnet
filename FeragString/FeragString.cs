using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feragstring
{


    internal class FeragString
    {

        private TitleInfo _titleInfo;
        private TitleEnd _titleEnd;

        public FeragString()
        {
            _titleInfo = new TitleInfo();
            _titleEnd = new TitleEnd();
        }

        public void SetTitleName(string titleName)
        {
            _titleInfo.TitleName = titleName;
            _titleEnd.TitleName = titleName;
        }

        public TitleInfo TitleInfo
        {
            get { return _titleInfo; }
            set { _titleInfo = value; }
        }

        // PrintOut returns the final FERAG string of the FeragString instance
        public string PrintOut()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(_titleInfo.Message());
            
            sb.Append(_titleEnd.Message());
            
            return sb.ToString();
        }

    }
}
