using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSim.Contracts
{
    interface IMailItem
    {
        string Subject { get; set; }
        string Body { get; set; }
        string SenderName { get; }
        void AddRecipient(string recipient);
        void AddAttachment(string fileName);
        void AddAttachment(IMailItem mailItem);
        void Send();
        void Delete();
        void Move(IMailFolder destination);
        bool ValidateRecipients();
        IMailItem Reply(bool replyAll);
        IMailItem Forward();
    }
}
