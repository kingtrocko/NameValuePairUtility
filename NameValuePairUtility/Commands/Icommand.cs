using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameValuePairUtility.Commands
{
    public interface Icommand
    {
        CommandResult Execute(CommandArg cmdArg);
    }
}