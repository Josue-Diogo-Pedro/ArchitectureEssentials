namespace SOLID.OCP.Soluction;

public class DebitCurrentCount : CountDebit
{
    public override string Debit(decimal value, string count)
    {
        //Debit current count
        return TransactionFormater();
    }
}
