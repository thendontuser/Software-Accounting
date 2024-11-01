using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Software_Accounting_Client_
{
    /// <summary>
    /// Обеспечивает работу с базой данных PostgreSQL
    /// </summary>
    internal class DataBase
    {
        // Соединение с базой данных
        private NpgsqlConnection Connection;

        // Строка подключения
        private readonly string ConnectionString;

        /// <summary>
        /// Инициализирует объект и открывает соединение с базой данных
        /// </summary>
        /// <param name="connectionString">Строка подключения</param>
        public DataBase(string connectionString)
        {
            Connection = new NpgsqlConnection(connectionString);
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Открывает соединение с базой данных
        /// </summary>
        public int Connect()
        {
            try
            {
                Connection.Open();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// Создает нового пользователя в базе данных
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {
            string sql = "INSERT INTO \"User\"(surname, name, middlename, role, id_device, password_hash) VALUES (@surname, @name, @middlename, @role, @id_device, @password_hash);";
            try
            {
                NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
                NpgsqlCommand cmd = dataSource.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@surname", user.Surname);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@middlename", user.Middlename);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@id_device", user.IdDevice);
                cmd.Parameters.AddWithValue("@password_hash", user.Password.GetHashCode().ToString());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Ищет пользователя в системе
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true, если пользователь сущестует, иначе false</returns>
        public bool IsExists(User user)
        {
            string sql = "SELECT * FROM \"User\";";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, ConnectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1], user.Surname) && string.Equals(row.ItemArray[2], user.Name) && string.Equals(row.ItemArray[3], user.Middlename) &&
                        string.Equals(row.ItemArray[6], user.Password.GetHashCode().ToString()) && string.Equals(row.ItemArray[4], user.Role))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Закрывает соединение с базой данных
        /// </summary>
        public void Disconnect()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}