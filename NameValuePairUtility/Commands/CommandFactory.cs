using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Actions;

namespace NameValuePairUtility.Commands
{
    public class CommandFactory
    {
        public static Icommand CreateCommand(string buttonName)
        {
            switch (buttonName)
            {
                case "btnAdd" :return new ExecuteAdd();
                case "btnDelete": return new ExecuteDelete();
                default: return null;
            }
        }
    }
}