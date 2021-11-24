using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vehicle : MonoBehaviour
{

    public Material materialOn;
    public Material materialOff;
    [SerializeField] private float speed;
    private string infoText;
    public string InfoText 
    {
        get {
            return infoText;
        }
        set
        {
            // Maximal text length
            if (value.Length > 100)
            {
                infoText = value.Substring(0, 100);
            } else
            {
                infoText = value;
            }
        }
    }
    public TMP_Text infoTextHolder;
    public GameObject idSphere;

    public bool moving { get; private set; }


    public Vehicle()
    {
        moving = false;
    }

    private void Update()
    {
        if (moving) {
            Move(Vector3.forward);
        }
    }


    public void SetMoving()
    {
        Material lightMaterial = null;
        if (moving)
        {
            lightMaterial = materialOff;
            moving = false;
        } else
        {
            lightMaterial = materialOn;
            moving = true;
        }

        idSphere.GetComponent<Renderer>().material = lightMaterial;
        ShowInfo();
    }
        

    public void ShowInfo()
    {
        if (moving)
        {
            infoTextHolder.SetText("\"" + InfoText + "\" is moving.");
        } else
        {
            infoTextHolder.SetText("\"" + InfoText + "\" has stopped.");
        }
        
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
