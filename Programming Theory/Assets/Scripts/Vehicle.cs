using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vehicle : MonoBehaviour
{

    public Material materialOn;
    public Material materialOff;
    [SerializeField] private float speed;
    public string infoText;
    public TMP_Text infoTextHolder;

    private bool isMoving;


    public Vehicle()
    {
        isMoving = false;
    }

    private void Update()
    {
        if (isMoving) {
            Move();
        }
    }

    //public abstract void SwitchLight(bool turnOn);


    public void ShowInfo()
    {
        infoTextHolder.SetText("Vehicle name: " + infoText);
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
