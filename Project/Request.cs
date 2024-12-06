using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет заявку пользователей системы
    /// </summary>
    internal class Request
    {
        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public int Id;

        /// <summary>
        /// Идентификатор ПО
        /// </summary>
        public int IdSoftware {  get; set; }

        /// <summary>
        /// Идентификатор разработчика
        /// </summary>
        public int IdDeveloper { get; set; }

        /// <summary>
        /// Идентификатор компьютера
        /// </summary>
        public int IdDevice { get; set; }

        /// <summary>
        /// Фамилия Имя Отчество
        /// </summary>
        public string SNM { get; set; }
    }
}