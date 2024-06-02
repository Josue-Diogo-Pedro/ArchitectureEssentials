namespace SOLID.OCP.Soluction;

public class DebitInvestimentCount : CountDebit
{
    public override string Debit(decimal value, string count)
    {
        //Debit investiment count
        //Insert taxas
        return TransactionFormater();
    }
}
