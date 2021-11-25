using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] cars;
    private GUIManager guiManager;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Bus bus = GameObject.FindObjectOfType<Bus>();
            bus.SetMoving();
        }
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            Van van = GameObject.FindObjectOfType<Van>();
            van.SetMoving();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Car car = GameObject.FindObjectOfType<Car>();
            car.SetMoving();
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            UFO ufo = GameObject.FindObjectOfType<UFO>();
            ufo.SetMoving();
        }
    }    


}
