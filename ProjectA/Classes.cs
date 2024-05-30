namespace ProjectA;


#region Classes

public class Public
{
    public void PublicTest() { }
    private void PrivateTest() { }
    internal void InternalTest() { }
    protected void ProtectedTest() { }
    private protected void PrivateProtectedTest() { }
    protected internal void ProtectedInternalTest() { }
}

public sealed class Selead { }

class Private { }

internal class Internal { }

abstract class Abstract { }

#endregion


#region Tests

class TestClasses
{
    public TestClasses()
    {
        var publica = new Public();
        var privada = new Private();
        var interna = new Internal();
        //var abstracta = new Abstract(); is not possible
    }

    //class TestSelead : Selead { } is not possible

}

class TestModifier1
{
    public TestModifier1()
    {
        Public publica = new();
        publica.PublicTest();
        publica.InternalTest();
        publica.ProtectedInternalTest();
        //publica.ProtectedTest(); is not possible
        //publica.ProtectedPrivateTest(); is not possible
        //publica.PrivateTest(); is not possible
    }
}

#endregion

/***************************************************************************/
// public:

// Access is not restricted.
/***************************************************************************/
// protected:

// Access is limited to the containing class or types
// derived from containing class.
/***************************************************************************/
// internal:

// Access is limited to the current assembly.
/***************************************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/***************************************************************************/
// private:

// Access is limited to the containing type.
/***************************************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly. Avaliable since C# 7.2
