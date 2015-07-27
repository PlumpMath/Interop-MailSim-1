using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSim.Contracts
{
    interface IAddressBook
    {
        IEnumerable<string> GetUsers(string match);
        IEnumerable<string> GetDLMembers(string dLName);
    }
}
