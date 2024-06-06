﻿using SOLID.ISR.Soluction.Interfaces;

namespace SOLID.ISR.Soluction;

public class RegisterClient : IRegisterClient
{
    public void ValidateDatas()
    {
        //validate datas
    }

    public void SaveInDataBse()
    {
        //register in database
    }

    public void SendEmail()
    {
        //send email to client
    }

}
