using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public enum TypeC
{
    Wood,
    Rubber
}


public class Resources : MonoBehaviour
{
    public int price;
    public string resourceName;
    public TypeC tip = TypeC.Wood;
}

