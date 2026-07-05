using System.Data;
using NpgsqlTypes;
using Npgsql;

namespace accounting.Models;

public class UserData
{
    private static readonly string[] _orderByCmd = { @"ORDER BY first_name;", @"ORDER BY middle_name;", @"ORDER BY last_name;", @"ORDER BY login;", @"ORDER BY email;", @"ORDER BY licenses;", @"ORDER BY first_name DESC;", @"ORDER BY middle_name DESC;", @"ORDER BY last_name DESC;", @"ORDER BY login DESC;", @"ORDER BY email DESC;", @"ORDER BY licenses DESC;" };
    private static readonly string _selectCmd = @"SELECT id, first_name, middle_name, last_name, login, email, licenses FROM user_data";
    private static readonly string _insertCmd = @"INSERT INTO user_data(first_name, middle_name, last_name, login) VALUES(@FirstName, @MiddleName, @LastName, @Login)";
    private static readonly string _updateCmd = @"UPDATE user_data SET last_name = @LastName, middle_name = @MiddleName, first_name = @FirstName, login = @Login WHERE id = @Id";
    private static readonly string _deleteCmd = @"DELETE FROM user_data WHERE id = @Id";

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public int Licenses { get; set; }

    public static List<UserData> Select(NpgsqlConnection connection, int sort_col = -1)
    {
        List<UserData> users = new List<UserData>();
        using(NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _selectCmd + (sort_col == -1 ? @";" : @" " + _orderByCmd[sort_col]);
                cmd.CommandType = CommandType.Text;
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserData userData = new UserData
                    {
                        Id = (Guid)reader["id"],
                        FirstName = (string)reader["first_name"],
                        MiddleName = (string)reader["middle_name"],
                        LastName = (string)reader["last_name"],
                        Login = (string)reader["login"],
                        Email = (string)reader["email"],
                        Licenses = (int)reader["licenses"]
                    };
                    users.Add(userData);
                }
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
        return users;
    }

    public static void Insert(NpgsqlConnection connection, UserData userData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _insertCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@FirstName", NpgsqlDbType.Text).Value = userData.FirstName;
                cmd.Parameters.Add("@MiddleName", NpgsqlDbType.Text).Value = userData.MiddleName;
                cmd.Parameters.Add("@LastName", NpgsqlDbType.Text).Value = userData.LastName;
                cmd.Parameters.Add("@Login", NpgsqlDbType.Text).Value = userData.Login;
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }

    public static void Update(NpgsqlConnection connection, UserData userData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _updateCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@FirstName", NpgsqlDbType.Text).Value = userData.FirstName;
                cmd.Parameters.Add("@MiddleName", NpgsqlDbType.Text).Value = userData.MiddleName;
                cmd.Parameters.Add("@LastName", NpgsqlDbType.Text).Value = userData.LastName;
                cmd.Parameters.Add("@Login", NpgsqlDbType.Text).Value = userData.Login;
                cmd.Parameters.Add("@Id", NpgsqlDbType.Uuid).Value = userData.Id;
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }

    public static void Delete(NpgsqlConnection connection, Guid id)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _deleteCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Id", NpgsqlDbType.Uuid).Value = id;
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }
}