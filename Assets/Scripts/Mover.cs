using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // serialize to access the variable in the editor
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float turnSpeed = 19.1f;
    void Start()
    {
       
    }

    void Update()
    {
        MoveTank();
        TurnTank();
        
        
    }
    void MoveTank ()
    {
        float roll = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(roll, 0, 0);
    }

    void TurnTank ()
    {
       if (Input.GetKey(KeyCode.UpArrow))
        {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
       if (Input.GetKey(KeyCode.DownArrow))
        {
        transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
    }
}
