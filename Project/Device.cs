using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет устройство в базе данных
    /// </summary>
    internal class Device
    {
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название устройства
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Операционная система, установленная на устройстве
        /// </summary>
        public string OS { get; set; }

        /// <summary>
        /// IP адрес устройства
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Оперативная память устройства
        /// </summary>
        public int RAM { get; set; }
    }
}