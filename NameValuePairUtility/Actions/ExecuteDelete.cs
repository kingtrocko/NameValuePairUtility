using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteDelete : Icommand
    {

        public CommandResult Execute(CommandArg cmdArg)
        {
            CommandResult result = Utility.Instance.Remove(cmdArg);
            return result;
        }
    }
}