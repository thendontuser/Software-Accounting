using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет пользователя системы
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// Роль пльзователя в системе
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login {  get; set; }

        /// <summary>
        /// Идентификатор компьютера, за которым пользователь может работать
        /// </summary>
        public int IdDevice { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}