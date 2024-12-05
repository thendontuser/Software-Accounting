using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            string sql = "INSERT INTO \"User\"(surname, name, middlename, role, id_device, password_hash, login) VALUES (@surname, @name, @middlename, @role, @id_device, @password_hash, @login);";
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
                cmd.Parameters.AddWithValue("@login", user.Login);
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
                    if (string.Equals(row.ItemArray[7].ToString(), user.Login) && string.Equals(row.ItemArray[6].ToString(), user.Password.ToString()))
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
        /// Ищет ПО в системе
        /// </summary>
        /// <param name="software"></param>
        /// <returns>true, если ПО существует в таблице, иначе false</returns>
        public bool IsExists(Software software, bool isFull)
        {
            string sql = "SELECT * FROM \"Software\";";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, ConnectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (!isFull)
                {
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        if (string.Equals(row.ItemArray[1].ToString(), software.Name) && string.Equals(row.ItemArray[6].ToString(), software.IdDevice.ToString())
                            && string.Equals(row.ItemArray[7].ToString(), software.IdDeveloper.ToString()))
                        {
                            return true;
                        }
                    }
                    return false;
                }

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1].ToString(), software.Name) && string.Equals(row.ItemArray[6].ToString(), software.IdDevice.ToString()))
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
        /// Ищет разработчиков в системе
        /// </summary>
        /// <param name="developer"></param>
        /// <returns></returns>
        public bool IsExists(Developer developer)
        {
            string sql = "SELECT * FROM \"Developer\";";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, ConnectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1].ToString(), developer.Name))
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
        /// Ишет устройства в системе
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public bool IsExists(Device device)
        {
            string sql = "SELECT * FROM \"Device\";";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, ConnectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[3].ToString(), device.IPAddress))
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
        /// Получает все записи в указанной таблице
        /// </summary>
        /// <param name="tableName">Название таблицы</param>
        /// <returns>DataSet</returns>
        public DataSet GetTable(string tableName)
        {
            string sql = $"SELECT * FROM \"{tableName}\";";
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, ConnectionString);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Заносит данные заявки в таблицу Request
        /// </summary>
        public void AddRequest(Request request)
        {
            string sql = "INSERT INTO \"Request\"(id_software, id_developer, id_device, \"SNM\") VALUES (@id_soft, @id_dev, @id_device, @snm);";
            try
            {
                NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
                NpgsqlCommand cmd = dataSource.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@id_soft", request.IdSoftware);
                cmd.Parameters.AddWithValue("@id_dev", request.IdDeveloper);
                cmd.Parameters.AddWithValue("@id_device", request.IdDevice);
                cmd.Parameters.AddWithValue("@snm", request.SNM);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирует данные в таблице Developer в зависимости от значения команды
        /// </summary>
        /// <param name="dev"></param>
        public void EditDeveloper(Developer dev, SqlCommand sqlCmd)
        {
            string sql = string.Empty;
            NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
            NpgsqlCommand cmd;

            switch (sqlCmd)
            {
                case SqlCommand.INSERT:
                    sql = "INSERT INTO \"Developer\" (name, type_of_company, location) VALUES (@name, @toc, @location);";
                    cmd = dataSource.CreateCommand(sql);
                    break;
                case SqlCommand.UPDATE:
                    sql = "UPDATE \"Developer\" SET name = @name, type_of_company = @toc, location = @location WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", dev.ID);
                    break;
                case SqlCommand.DELETE:
                    sql = "DELETE FROM \"Developer\" WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", dev.ID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                default:
                    cmd = dataSource.CreateCommand(sql);
                    break;
            }

            try
            {
                cmd.Parameters.AddWithValue("@name", dev.Name);
                cmd.Parameters.AddWithValue("@toc", dev.TypeOfCompany);
                cmd.Parameters.AddWithValue("@location", dev.Location);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирует данные в таблице Software в зависимости от значения команды
        /// </summary>
        /// <param name="soft"></param>
        /// <param name="sqlCmd"></param>
        public void EditSoftware(Software soft, SqlCommand sqlCmd)
        {
            string sql = string.Empty;
            NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
            NpgsqlCommand cmd;

            switch (sqlCmd)
            {
                case SqlCommand.INSERT:
                    sql = "INSERT INTO \"Software\" (name, version, license, license_begin, license_end, id_device, id_developer, logo) VALUES (@name, @version, @license, @lb, @le, @id_device, @id_dev, @logo);";
                    cmd = dataSource.CreateCommand(sql);
                    break;
                case SqlCommand.UPDATE:
                    sql = "UPDATE \"Software\" SET name = @name, version = @version, license = @license, license_begin = @lb, license_end = @le, id_device = @id_device, id_developer = @id_dev, logo = @logo WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", soft.Id);
                    break;
                case SqlCommand.DELETE:
                    sql = "DELETE FROM \"Software\" WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", soft.Id);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                default:
                    cmd = dataSource.CreateCommand(sql);
                    break;
            }

            try
            {
                if (soft.LogoPath == null)
                {
                    cmd.Parameters.AddWithValue("@logo", ImageByteA.GetImageBytes(ImageByteA.WHITE_NOISE));
                }
                else
                {
                    NpgsqlParameter logo = new NpgsqlParameter();
                    logo.ParameterName = "@logo";
                    logo.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                    logo.Value = ImageByteA.GetImageBytes(soft.LogoPath);
                    cmd.Parameters.AddWithValue(logo.ParameterName, (byte[])logo.Value);
                }
                cmd.Parameters.AddWithValue("@name", soft.Name);
                cmd.Parameters.AddWithValue("@version", soft.Version);
                cmd.Parameters.AddWithValue("@license", soft.License);
                cmd.Parameters.AddWithValue("@lb", Convert.ToDateTime(soft.LicenseBegin));
                cmd.Parameters.AddWithValue("@le", Convert.ToDateTime(soft.LicenseEnd));
                cmd.Parameters.AddWithValue("@id_device", soft.IdDevice);
                cmd.Parameters.AddWithValue("@id_dev", soft.IdDeveloper);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирует данные в таблице Device в зависимости от значения команды
        /// </summary>
        /// <param name="device"></param>
        public void EditDevice(Device device, SqlCommand sqlCmd)
        {
            string sql = string.Empty;
            NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
            NpgsqlCommand cmd;

            switch (sqlCmd)
            {
                case SqlCommand.INSERT:
                    sql = "INSERT INTO \"Device\" (name, \"OS\", ip_address, \"RAM\") VALUES (@name, @os, @ip, @ram);";
                    cmd = dataSource.CreateCommand(sql);
                    break;
                case SqlCommand.UPDATE:
                    sql = "UPDATE \"Device\" SET name = @name, \"OS\" = @os, ip_address = @ip, \"RAM\" = @ram WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", device.ID);
                    break;
                case SqlCommand.DELETE:
                    sql = "DELETE FROM \"Device\" WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", device.ID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                default:
                    cmd = dataSource.CreateCommand(sql);
                    break;
            }

            try
            {
                cmd.Parameters.AddWithValue("@name", device.Name);
                cmd.Parameters.AddWithValue("@os", device.OS);
                cmd.Parameters.AddWithValue("@ip", device.IPAddress);
                cmd.Parameters.AddWithValue("@ram", device.RAM);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирует данные в таблице User в зависимости от значения команды
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sqlCmd"></param>
        public void EditUser(User user, SqlCommand sqlCmd)
        {
            string sql = string.Empty;
            NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
            NpgsqlCommand cmd;

            switch (sqlCmd)
            {
                case SqlCommand.UPDATE:
                    sql = "UPDATE \"User\" SET surname = @sn, name = @name, middlename = @mn, role = @role, id_device = @id_device WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", user.ID);
                    break;
                case SqlCommand.DELETE:
                    sql = "DELETE FROM \"User\" WHERE id = @id;";
                    cmd = dataSource.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@id", user.ID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                default:
                    cmd = dataSource.CreateCommand(sql);
                    break;
            }

            try
            {
                cmd.Parameters.AddWithValue("@sn", user.Surname);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@mn", user.Middlename);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@id_device", user.IdDevice);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Делает SQL запрос на получение данных из поля logo из таблицы Software и возвращает объект PictureBox
        /// </summary>
        /// <returns>PictureBox</returns>
        public Image GetImageByteA(int id)
        {
            PictureBox result = new PictureBox();
            string sql = "SELECT logo FROM \"Software\" WHERE id = @id";

            try
            {
                NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
                NpgsqlCommand cmd = dataSource.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@id", id);

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);

                using (NpgsqlDataReader reader = dataAdapter.SelectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            ms.Position = 0;
                            ms.Read((byte[])reader["logo"], 0, ((byte[])reader["logo"]).Length);
                            byte[] msb = ms.ToArray();
                            result.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source + " " + ex.TargetSite);
            }

            return result.Image;
        }

        /// <summary>
        /// Метод возвращает список данных о последней заявке
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<string> GetLastRequest(Request request)
        {
            List<string> result = new List<string>();
            string soft = string.Empty, dev = string.Empty, device = string.Empty;

            try
            {
                NpgsqlDataSource dataSource = NpgsqlDataSource.Create(ConnectionString);
                NpgsqlDataReader reader;

                // Получение ПО
                NpgsqlCommand cmd = dataSource.CreateCommand("SELECT name FROM \"Software\" WHERE id = @id;");
                cmd.Parameters.AddWithValue("@id", request.IdSoftware);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    soft = reader[0].ToString();
                }

                // Получение Разработчика
                cmd = dataSource.CreateCommand("SELECT name FROM \"Developer\" WHERE id = @id;");
                cmd.Parameters.AddWithValue("@id", request.IdDeveloper);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dev = reader[0].ToString();
                }

                // Получение Устройства
                cmd = dataSource.CreateCommand("SELECT name FROM \"Device\" WHERE id = @id;");
                cmd.Parameters.AddWithValue("@id", request.IdDevice);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    device = reader[0].ToString();
                }
                    
                // Запись данных
                result.Add(soft);
                result.Add(dev);
                result.Add(device);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
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