using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;

namespace NameValuePairUtility.Commands
{
    [Serializable]
    public class CommandResult
    {
        private object _scalarResult;
        private string _errorMessage = "";
        private Dictionary<string,string> _nvCollection;

        public Dictionary<string,string> NvCollection
        {
            get { return _nvCollection; }
            set { _nvCollection = value; }
        }
        
        public object ScalarResult
        {
            get { return _scalarResult; }
            set { _scalarResult = value; }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
    }
}