using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет таблицу разработчиков в базе данных
    /// </summary>
    internal class Developer
    {
        /// <summary>
        /// Идентификатор разработчика
        /// </summary>
        public int ID {  get; set; }

        /// <summary>
        /// Наименование разработчиков
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип компании
        /// </summary>
        public string TypeOfCompany { get; set; }

        /// <summary>
        /// Расположение компании
        /// </summary>
        public string Location { get; set; }
    }
}