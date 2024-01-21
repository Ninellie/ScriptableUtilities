using System;

[Serializable]
public abstract class VariableReference<T>
{
    public bool useConstant;
    public T constantValue;
    public Variable<T> variable;

    public T Value => useConstant ? constantValue : variable.value;

    public static implicit operator T(VariableReference<T> reference)
    {
        return reference.Value;
    }
}

[Serializable]
public class FloatReference : VariableReference<float>
{
    public FloatReference()
    { }

    public FloatReference(float value)
    {
        useConstant = true;
        constantValue = value;
    }

    public static implicit operator int(FloatReference reference)
    {
        return (int)reference.Value;
    }
}

[Serializable]
public class IntReference : VariableReference<int>
{
    public IntReference()
    { }

    public IntReference(int value)
    {
        useConstant = true;
        constantValue = value;
    }

    public static implicit operator float(IntReference reference)
    {
        return reference.Value;
    }
}