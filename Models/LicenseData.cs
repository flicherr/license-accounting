using System.Data;
using NpgsqlTypes;
using Npgsql;

namespace accounting.Models;

public class LicenseData
{
    private static readonly string[] _orderByCmd = { @"ORDER BY first_name ASC, middle_name ASC, last_name ASC;", @"ORDER BY title ASC, developer ASC;", @"ORDER BY purchased ASC;", @"ORDER BY license_key ASC;", @"ORDER BY ""price, usd"" ASC;", @"ORDER BY first_name DESC, middle_name DESC, last_name DESC;", @"ORDER BY title DESC, developer DESC;", @"ORDER BY purchased DESC;", @"ORDER BY license_key DESC;", @"ORDER BY ""price, usd"" DESC;" };
    private static readonly string _selectCmd = @"SELECT acq.id, user_data_id, program_data_id, first_name, middle_name, last_name, title, developer, purchased, available_license, license_key, ""price, usd"" FROM user_data, program_data, license, license_acquisition acq WHERE license_id = license.id AND user_data_id = user_data.id AND program_data_id = program_data.id";
    private static readonly string _insertCmd = @"CALL insert_license_data(@UserId, @ProgramId, @Purchased, @LicenseKey);";
    private static readonly string _updateCmd = @"CALL update_license_data(@Id, @UserId, @ProgramId, @Purchased, @LicenseKey);";
    private static readonly string _deleteCmd = @"CALL delete_license_data(@Id);";

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ProgramId { get; set; }
    public string User { get; set; }
    public string Program {  get; set; }
    public DateTime Purchased {  get; set; } = DateTime.Now;
    public int AvailableLicense {  get; set; }
    public string LicenseKey {  get; set; }
    public decimal Price { get; set; }

    public static List<LicenseData> Select(NpgsqlConnection connection, int sort_col = -1)
    {
        List<LicenseData> licenseData = new List<LicenseData>();
        using (NpgsqlCommand cmd = new NpgsqlCommand())
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
                    LicenseData LicenseData = new LicenseData
                    {
                        Id = (Guid)reader["id"],
                        UserId = (Guid)reader["user_data_id"],
                        ProgramId = (Guid)reader["program_data_id"],
                        User = (string)reader["first_name"] + " " + (string)reader["middle_name"] + " " + ((string)reader["last_name"])[0].ToString() + ".",
                        Program = (string)reader["title"] + ", " + (string)reader["developer"],
                        Purchased = (DateTime)reader["purchased"],
                        AvailableLicense = (int)reader["available_license"],
                        LicenseKey = (string)reader["license_key"],
                        Price = (decimal)reader["price, usd"]
                    };
                    licenseData.Add(LicenseData);
                }
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
        return licenseData;
    }

    public static void Insert(NpgsqlConnection connection, LicenseData LicenseData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _insertCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@UserId", NpgsqlDbType.Uuid).Value = LicenseData.UserId;
                cmd.Parameters.Add("@ProgramId", NpgsqlDbType.Uuid).Value = LicenseData.ProgramId;
                cmd.Parameters.Add("@Purchased", NpgsqlDbType.Date).Value = LicenseData.Purchased;
                cmd.Parameters.Add("@LicenseKey", NpgsqlDbType.Text).Value = LicenseData.LicenseKey;
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }

    public static void Update(NpgsqlConnection connection, LicenseData LicenseData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _updateCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Id", NpgsqlDbType.Uuid).Value = LicenseData.Id;
                cmd.Parameters.Add("@UserId", NpgsqlDbType.Uuid).Value = LicenseData.UserId;
                cmd.Parameters.Add("@ProgramId", NpgsqlDbType.Uuid).Value = LicenseData.ProgramId;
                cmd.Parameters.Add("@Purchased", NpgsqlDbType.Date).Value = LicenseData.Purchased;
                cmd.Parameters.Add("@LicenseKey", NpgsqlDbType.Text).Value = LicenseData.LicenseKey;
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
