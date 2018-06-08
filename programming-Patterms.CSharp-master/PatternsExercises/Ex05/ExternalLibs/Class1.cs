using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.ExternalLibs
{
    class Class1
    {
        DatabaseSaver databaseS;
        MailSender mailS;
        CacheUpdater cacheUp;

        public void Do(MailSender mailS, CacheUpdater cachUp, DatabaseSaver databaseS)
        {


        }

        public void Do(MailSender mailS, DatabaseSaver databaseS)
        {


        }

        public void Do(MailSender mailS, CacheUpdater cachUp)
        {


        }
        public void Do(MailSender mailS)
        {


        }

    }
}
