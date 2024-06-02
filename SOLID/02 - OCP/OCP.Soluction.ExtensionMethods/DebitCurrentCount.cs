namespace SOLID.OCP.Soluction.ExtensionMethods;

public static class DebitCurrentCount
{
    public static string DebitCurrentAccount(this CountDebit countDebit)
    {
        //business logic to debit current count
        return countDebit.TransactionFormater();
    }
}
