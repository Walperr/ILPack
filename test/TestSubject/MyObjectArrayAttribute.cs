using System;

namespace TestSubject;

public class MyObjectArrayAttribute : Attribute
{
    public MyObjectArrayAttribute(object[] values)
    {
        Values = values;
    }

    public object[] Values { get; }
}