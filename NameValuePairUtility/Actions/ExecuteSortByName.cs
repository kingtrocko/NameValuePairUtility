using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteSortByName: Icommand 
    {
        #region Icommand Members

        public CommandResult Execute(CommandArg cmdArg)
        {
            CommandResult cmdResult = Utility.Instance.SortByName(cmdArg);
            return cmdResult;
        }

        #endregion
    }
}