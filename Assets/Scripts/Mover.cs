using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // serialize to access the variable in the editor
    [SerializeField] float moveSpeed = 1.7f;
    [SerializeField] float turnSpeed = 19.1f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float roll = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(roll, 0, 0);
        TurnTank();
        
        
    }

    void TurnTank ()
    {
    //    if (Input.GetKeyDown(KeyCode.UpArrow))
    //     {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        // }
    }
}
