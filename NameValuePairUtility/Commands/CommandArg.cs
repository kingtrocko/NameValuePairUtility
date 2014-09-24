using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Web.UI.WebControls;

namespace NameValuePairUtility.Commands
{
    [Serializable]
    public class CommandArg
    {
        private string _value;
        private ListBox _listBox;

        public ListBox ListBox
        {
            get { return _listBox; }
            set { _listBox = value; }
        } 

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

    }
}