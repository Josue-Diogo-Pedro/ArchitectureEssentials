namespace SOLID.SRP.Soluction;

public class ClientService
{
    public string AddClient(Client client)
    {
        if (!client.Validate()) return "Invlid datas";

        var repo = new ClientRepository();
        repo.AddClient(client);

        EmailServices.Send("empresa@empresa.com", client.Email.Address, "Welcome!", "Congruatulations! You are inserted*(cadastrado, in portuguese rsrs)");

        return "Client inserted with success";
    }
}
