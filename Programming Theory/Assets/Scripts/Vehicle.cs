using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Vehicle : MonoBehaviour
{

    [SerializeField] private Material materialOn;
    [SerializeField] private Material materialOff;
    [SerializeField] private float speed;
    [SerializeField] private string infoText;
    public TMP_Text infoTextHolder;


    public Vehicle()
    {

    }

    private void Update()
    {
        

    }

    public abstract void SwitchLight(bool turnOn);


    public void ShowInfo()
    {
        infoTextHolder.SetText("Vehicle name: " + infoText);
    }

}
