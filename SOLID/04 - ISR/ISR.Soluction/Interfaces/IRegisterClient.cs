namespace SOLID.ISR.Soluction.Interfaces;

public interface IRegisterClient : IRegister
{
    void ValidateDatas();
    void SendEmail();
}
