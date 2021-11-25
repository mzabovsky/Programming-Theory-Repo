using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class UFO : Vehicle
{

    public float maxHeight = 20;
    public float minHeight = 7.5f;

    private Vector3 verticalDirection = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        InfoText = "UFO";
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            if ((gameObject.transform.position.y >= maxHeight) && (verticalDirection == Vector3.up)) 
            {
                verticalDirection = Vector3.down;
            } else if ((gameObject.transform.position.y <= minHeight) && (verticalDirection == Vector3.down)) 
            {
                verticalDirection = Vector3.up;
            }

            Move(Vector3.forward, verticalDirection);
        }
    }
}
