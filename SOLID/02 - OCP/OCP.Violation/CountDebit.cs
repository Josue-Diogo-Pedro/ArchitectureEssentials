namespace SOLID.OCP.Violation;

public class CountDebit
{
    public void Debit(decimal value, string count, CountKind countKind)
    {
        if(countKind == CountKind.Current)
        {
            //debit current count
        }

        if(countKind == CountKind.Poupance)
        {
            //validate birthdate of count
            //apply poupance count debit
        }
    }
}
