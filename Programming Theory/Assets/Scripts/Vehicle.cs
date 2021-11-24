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
    public GameObject idSphere;

    public bool isMoving;


    public Vehicle()
    {
        isMoving = false;
    }

    private void Update()
    {
        if (isMoving) {
            Move(Vector3.forward);
        }
    }


    public void SetMoving()
    {
        Material lightMaterial = null;
        if (isMoving)
        {
            lightMaterial = materialOff;
            isMoving = false;
        } else
        {
            lightMaterial = materialOn;
            isMoving = true;
        }

        idSphere.GetComponent<Renderer>().material = lightMaterial;
    }
        

    public void ShowInfo()
    {
        infoTextHolder.SetText("Vehicle \"" + infoText + "\" is moving.");
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Move(Vector3 direction, Vector3 verticalDirection)
    {
        Vector3 dirVector = direction + verticalDirection;
        transform.Translate(dirVector * speed * Time.deltaTime);
    }
}
