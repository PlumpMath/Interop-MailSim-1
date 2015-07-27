using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSim.Contracts
{
    interface IMailFolder
    {
        string Name { get; }
        string FolderPath { get; }
        IEnumerable<IMailItem> MailItems { get; }
        IEnumerable<IMailFolder> SubFolders { get; }
        void RegisterItemAddEventHandler(Action<IMailItem> callback);
        void UnRegisterItemAddEventHandler();
        int MailItemsCount { get; }
        int SubFoldersCount { get; }
        IMailFolder AddSubFolder(string name);
        void Delete();
    }
}
