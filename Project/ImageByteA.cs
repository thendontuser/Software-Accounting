using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Представляет функционал для работы с типом bytea базы данных
    /// </summary>
    internal static class ImageByteA
    {
        public const string WHITE_NOISE = "C:\\Users\\andrk\\Desktop\\лабы\\3 курс 1 семестр\\бд\\курсач\\icons\\whitenoise.jpeg";

        /// <summary>
        /// Возвращает массив байтов изображения
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static byte[] GetImageBytes(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(new BufferedStream(fs)))
                {
                    return br.ReadBytes(Convert.ToInt32(fs.Length));
                }
            }
        }
    }
}