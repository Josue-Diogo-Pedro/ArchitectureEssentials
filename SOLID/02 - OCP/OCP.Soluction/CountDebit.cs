namespace SOLID.OCP.Soluction;

public abstract class CountDebit
{
    public string TransactionNumber { get; set; }
    public abstract string Debit(decimal value, string count);

    public string TransactionFormater()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        TransactionNumber = new string(Enumerable.Repeat(chars, 15).
            Select(s => s[random.Next(s.Length)]).ToArray());

        //number of formated transaction
        return TransactionNumber;
    }
}
