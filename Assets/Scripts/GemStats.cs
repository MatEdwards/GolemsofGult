using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

enum Attributes
{
    TOUGHNESS,
    INTELLECT,
    PROWESS,
    SMARM,
    FURY,
    APATHY
}

public class GemStats : MonoBehaviour
{
    [SerializeField]
    Attributes[] Attribute;

    Attributes[] GetAttributes()
    {
        return Attribute;
    }
}
