using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет настройки подключения к базе данных
    /// </summary>
    internal static class DBSettings
    {
        private const string _ConnectionString = "Host = localhost; Username = postgres; Password = Anyathebestgirl; Database = software_accounting";

        /// <summary>
        /// Возвращает строку подключеня
        /// </summary>
        public static string ConnectionString { get { return _ConnectionString; } }
    }
}