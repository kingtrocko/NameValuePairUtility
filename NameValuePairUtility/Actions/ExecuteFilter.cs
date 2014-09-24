using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteFilter : Icommand
    {
        #region Icommand Members

        public CommandResult Execute(CommandArg cmdArg)
        {
            CommandResult cmdResult = Utility.Instance.Filter(cmdArg);
            return cmdResult;
        }

        #endregion
    }
}