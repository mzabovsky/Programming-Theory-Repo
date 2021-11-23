using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] cars;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CheckKeyPressed();
        if (Input.GetKeyDown(KeyCode.U))
        {
            UFO vehicle = FindObjectOfType<UFO>();
            vehicle.SetMoving();

        }
    }

    private void CheckKeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            UFO vehicle = FindObjectOfType<UFO>();
            vehicle.SetMoving();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {

        }
    }
    
}
