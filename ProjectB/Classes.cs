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

}

class TestModifier2
{

}