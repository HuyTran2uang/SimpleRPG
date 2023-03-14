using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    [field: SerializeField] public LanguageType Type { get; private set; }

    public void SetLanguageType(LanguageType type)
    {
        Type = type;
    }
}

public enum LanguageType
{
    English,
    Vietnamese
}
