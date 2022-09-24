using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasariCariKart
{
    enum AuthenticationType : byte { Windows, Sql }


    class Settings
    {
        public string ServerName { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string DbName { get; set; }

        public AuthenticationType Authentication { get; set; }

        public string ConnectionStringMaster
        {
            get
            {
                if (Authentication == AuthenticationType.Windows)
                {
                    return string.Format("Data Source={0};Initial Catalog=master;Integrated Security=True", ServerName);
                }
                else
                {
                    return string.Format
                        ("Data Source={0};Initial Catalog=master;User Id={1};Password={2}", ServerName, UserName, Password);
                }
            }
        }
        public string ConnectionString
        {
            get
            {
                if (Authentication == AuthenticationType.Windows)
                {
                    return string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", ServerName, DbName);
                }
                else
                {
                    return string.Format
                        ("Data Source={0};Initial Catalog={1};User Id={2};Password={3}", ServerName, DbName, UserName, Password);
                }
            }
        }
    }
}
