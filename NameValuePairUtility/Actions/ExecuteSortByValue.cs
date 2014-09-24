using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteSortByValue : Icommand
    {
        #region Icommand Members

        public CommandResult Execute(CommandArg cmdArg)
        {
            CommandResult cmdResult = Utility.Instance.SortByValue(cmdArg);
            return cmdResult;
        }

        #endregion
    }
}