using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    private GameObject shopButton;

    public int money;
    private bool shopistrue;
    void Start()
    {
        money = money + 5;
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        shopistrue = true;
        shopButton.SetActive(shopistrue);
    }

    private void TurnOnAndOff()
    {
        shopistrue ^= true;
        shopButton.SetActive((shopistrue));
    }
}
