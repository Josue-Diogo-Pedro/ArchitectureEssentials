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
