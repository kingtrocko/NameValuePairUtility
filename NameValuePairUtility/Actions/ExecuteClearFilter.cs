using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NameValuePairUtility.Commands;

namespace NameValuePairUtility.Actions
{
    public class ExecuteClearFilter : Icommand
    {
        #region Icommand Members

        CommandResult Icommand.Execute(CommandArg cmdArg)
        {
            CommandResult result = Utility.Instance.ClearFilter(cmdArg);
            return result;
        }

        #endregion
    }
}