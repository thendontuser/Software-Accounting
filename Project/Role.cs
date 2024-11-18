using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Класс используется только для проверки роли пользователя
    /// </summary>
    internal static class Role
    {
        /// <summary>
        /// Текущая роль пользователя в системе
        /// </summary>
        public static string CurrentRole { get; set; }
    }
}