using System.Data;
using NpgsqlTypes;
using Npgsql;

namespace accounting.Models;

public class ProgramData
{
    private static readonly string _selectCmd = @"SELECT program_data.id, title, product_description, developer, type_id, category, description, available_license, ""price, usd"" FROM program_data, type_software ts WHERE type_id = ts.id;";
    private static readonly string _insertCmd = @"INSERT INTO program_data(title, product_description, developer, type_id, ""price, usd"", available_license) VALUES(@Title, @ProductDescription, @Developer, @TypeId, @PriceUsd, @AvailableLicense);";
    private static readonly string _updateCmd = @"UPDATE program_data SET title = @Title, product_description = @ProductDescription, developer = @Developer, type_id = @TypeId, ""price, usd"" = @PriceUsd, available_license = @AvailableLicense WHERE id = @Id";
    private static readonly string _deleteCmd = @"DELETE FROM program_data WHERE id = @Id";

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string ProductDescription { get; set; }
    public string Developer {  get; set; }
    public Guid TypeId { get; set; }
    public string Category {  get; set; }
    public string DescriptionCategory {  get; set; }
    public int AvailableLicence { get; set; }
    public decimal PriceUsd { get; set; }

    public static List<ProgramData> Select(NpgsqlConnection connection, int sort_col = 0)
    {
        List<ProgramData> programs = new List<ProgramData>();
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _selectCmd;
                cmd.CommandType = CommandType.Text;
                connection.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProgramData programData = new ProgramData
                    {
                        Id = (Guid)reader["id"],
                        Title = (string)reader["title"],
                        ProductDescription = (string)reader["product_description"],
                        Developer = (string)reader["developer"],
                        TypeId = (Guid)reader["type_id"],
                        Category = (string)reader["category"],
                        DescriptionCategory = (string)reader["description"],
                        AvailableLicence = (int)reader["available_license"],
                        PriceUsd = (decimal)reader["price, usd"]
                    };
                    programs.Add(programData);
                }
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
        return programs;
    }

    public static void Insert(NpgsqlConnection connection, ProgramData programData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _insertCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Title", NpgsqlDbType.Text).Value = programData.Title;
                cmd.Parameters.Add("@ProductDescription", NpgsqlDbType.Text).Value = programData.ProductDescription;
                cmd.Parameters.Add("@Developer", NpgsqlDbType.Text).Value = programData.Developer;
                cmd.Parameters.Add("@TypeId", NpgsqlDbType.Uuid).Value = programData.TypeId;
                cmd.Parameters.Add("@PriceUsd", NpgsqlDbType.Numeric).Value = programData.PriceUsd;
                cmd.Parameters.Add("@AvailableLicense", NpgsqlDbType.Integer).Value = programData.AvailableLicence;
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }

    public static void Update(NpgsqlConnection connection, ProgramData programData)
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand())
        {
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = _updateCmd;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Title", NpgsqlDbType.Text).Value = programData.Title;
                cmd.Parameters.Add("@ProductDescription", NpgsqlDbType.Text).Value = programData.ProductDescription;
                cmd.Parameters.Add("@Developer", NpgsqlDbType.Text).Value = programData.Developer;
                cmd.Parameters.Add("@TypeId", NpgsqlDbType.Uuid).Value = programData.TypeId;
                cmd.Parameters.Add("@PriceUsd", NpgsqlDbType.Numeric).Value = programData.PriceUsd;
                cmd.Parameters.Add("@AvailableLicense", NpgsqlDbType.Integer).Value = programData.AvailableLicence;
                cmd.Parameters.Add("@Id", NpgsqlDbType.Uuid).Value = programData.Id;
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
