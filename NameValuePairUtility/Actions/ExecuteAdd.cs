using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteAdd : Icommand
    {
        
        public CommandResult Execute(CommandArg cmdArg)
        {
            CommandResult cmdResult = Utility.Instance.Add(cmdArg);
            return cmdResult;
        }
    }
}