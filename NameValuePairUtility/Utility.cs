using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility
{
    public sealed class Utility
    {
        private static readonly Utility instance = new Utility();
        private Dictionary<string, string> nvCollection = new Dictionary<string, string>();

        public Dictionary<string, string> NvCollection
        {
            get { return nvCollection; }
        }

        private Utility()
        {
            
        }

        public static Utility Instance
        {
            get 
            {
                return instance;
            }
        }

        public CommandResult Add(CommandArg arg)
        {
            CommandResult result = new CommandResult();
            try
            {
                string[] arr = arg.Value.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length == 0)
                    result.ErrorMessage = "The input does not contain the equal(=) operator or is Empty";
                else if (arr.Length != 2)
                    result.ErrorMessage = "The input is not well formed.\n Entry format should be as follow: name = value";
                else
                {
                    string key = (nvCollection.Count() + 1).ToString();
                    nvCollection.Add(key, arg.Value);
                    result.NvCollection = nvCollection;
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                //result.ScalarResult = ex;
            }
            return result;
        }

        public CommandResult Remove(CommandArg arg)
        {
            CommandResult result = new CommandResult();
            try
            {
                if (arg.ListBox.SelectedIndex != -1)
                {
                    string key = (arg.ListBox.SelectedIndex + 1).ToString();
                    nvCollection.Remove(key);
                    result.NvCollection = nvCollection;
                }
                else
                {
                    result.ErrorMessage = "You have not selected an Item in order to delete it.";
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public CommandResult SortByName(CommandArg arg)
        {
            CommandResult result = new CommandResult();

            var sorted = from nv in nvCollection
                         orderby nv.Value.Split('=')[0] ascending
                         select nv;
            //TODO : Implementation
            return result;
        }

        public CommandResult SortByValue(CommandArg arg)
        {
            CommandResult result = new CommandResult();
            return result;
            //TODO : Implementation
        }

        public CommandResult Filter(CommandArg arg)
        {
            CommandResult result = new CommandResult();
            return result;
            //TODO : Implementation
        }

        public CommandResult ClearFilter(CommandArg arg)
        {
            CommandResult result = new CommandResult();
            return result;
            //TODO : Implementation
        }

        
    }
}