using ProjectA;

namespace ProjectB;

class TestClasses
{
    public TestClasses()
    {
        Public publica = new();
        //Private privada = new(); is not possible. Note: will be possible if we able assembly for ProjectA
        //Internal interno = new(); is not possible Note: will be possible if we able assembly for ProjectA
        //Abstract abstracta = new(); is not possible Note: will be possible if we able assembly for ProjectA
    }
}

class TestModifier1
{
    public TestModifier1()
    {
        Public publica = new();
        //publica.InternalTest();
        //publica.ProtectedInternalTest(); is not possible
        //publica.ProtectedTest(); is not possible
        //publica.PrivateProtectedTest(); is not possible
        //publica.PrivateTest(); is not possible

    }
}

class TestModifier2 : Public
{
    public TestModifier2()
    {
        PublicTest();
        ProtectedTest();
        ProtectedInternalTest();
        //InternalTest(); is not possible
        //PrivateProtectedTest(); is not possible
        //PrivateTest(); is not possible
    }
}