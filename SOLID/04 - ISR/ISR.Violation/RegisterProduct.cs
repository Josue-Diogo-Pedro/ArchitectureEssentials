namespace SOLID.ISR.Violation;

public class RegisterProduct : ICadastro
{
    public void ValidateDatas()
    {
        //validate values
    }

    public void SaveDataBase()
    {
        //insert in product table
    }

    public void SendEmail()
    {
        //Product don't have email, what can i do now??
        throw new NotImplementedException("This method don't have implementation");
    }

}
