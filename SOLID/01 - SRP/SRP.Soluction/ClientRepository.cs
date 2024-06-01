namespace SOLID.SRP.Soluction;

public class ClientRepository
{
    public void AddClient(Client client)
    {
        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MyConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommnadType.Text;
            cmd.CommandText = "INSERT INTO Client(Name, Email, Cpf, InsertDate) Values(@name, @email, @cpf, @insertdate)";

            cmd.Parameters.AddWithValue("name", client.Name);
            cmd.Parameters.AddWithValue("email", client.Email.Address);
            cmd.Parameters.AddWithValue("cpf", client.Cpf.Number);
            cmd.Parameters.AddWithValue("insertdate", client.InsertDate);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
