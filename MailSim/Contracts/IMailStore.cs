using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSim.Contracts
{
    interface IMailStore
    {
        IMailItem NewMailItem();

        string DisplayName { get; }

        IMailFolder RootFolder { get; }

        IMailFolder GetDefaultFolder(string name);
        
        IAddressBook GetGlobalAddressList();
    }
}
