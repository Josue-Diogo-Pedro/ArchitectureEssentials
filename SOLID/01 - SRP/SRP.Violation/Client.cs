using System.Net.Mail;

namespace SOLID.SRP.Violation;

public class Client
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime InsertDate { get; set; }

    public string AddClient()
    {
        if (!Email.Contains("@")) return "Client with invalid e-mail";

        if (Cpf.Length != 11) return "Client with invalid cpf";

        using (var cn = new SqlConnection())
        {
            var cmd = new SqlCommand();

            cn.ConnectionString = "MyConnectionString";
            cmd.Connection = cn;
            cmd.CommandType = CommnadType.Text;
            cmd.CommandText = "INSERT INTO Client(Name, Email, Cpf, InsertDate) Values(@name, @email, @cpf, @insertdate)";

            cmd.Parameters.AddWithValue("name", Name);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("cpf", Cpf);
            cmd.Parameters.AddWithValue("insertdate", InsertDate);

            cn.Open();
            cmd.ExecuteNonQuery();
        }

        var mail = new MailMessage("empresa@empresa", Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Welcome!";
        mail.Body = "Congruatulations! You are inserted*(cadastrado, in portuguese rsrs)";
        client.Send(mail);

        return "Client inserted with success";
    }
}
