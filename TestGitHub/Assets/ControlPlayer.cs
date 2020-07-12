using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public int movementSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
    }
}
