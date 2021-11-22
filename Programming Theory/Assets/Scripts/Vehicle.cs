using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{

    [SerializeField] private Material materialOn;
    [SerializeField] private Material materialOff;
    [SerializeField] private float speed;
    [SerializeField] private string infoText;


    public Vehicle()
    {

    }

}
