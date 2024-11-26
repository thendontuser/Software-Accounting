using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет таблицу "Software" базы данных
    /// </summary>
    internal class Software
    {
        /// <summary>
        /// ID данного ПО
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название ПО
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// Версия ПО
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Лицензия ПО
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// Дата начала действия лицензии
        /// </summary>
        public string LicenseBegin { get; set; }

        /// <summary>
        /// Дата окончания действия лицензии
        /// </summary>
        public string LicenseEnd { get; set; }

        /// <summary>
        /// ID устройства, на котором данное ПО установлено
        /// </summary>
        public int IdDevice {  get; set; }

        /// <summary>
        /// ID разработчика данного ПО
        /// </summary>
        public int IdDeveloper { get; set; }

        /// <summary>
        /// Путь к файлу изображения
        /// </summary>
        public string LogoPath { get; set; }
    }
}