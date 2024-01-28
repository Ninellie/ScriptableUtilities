using UnityEngine;

public abstract class Variable<T> : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    public string developerDescription = "";
#endif
    public T value;

    public void SetValue(T value)
    {
        this.value = value;
    }

    public void SetValue(Variable<T> value)
    {
        this.value = value.value;
    }
}