using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // serialize to access the variable in the editor
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float turnSpeed = 19.1f;
    public AudioClip tankClip;
    AudioSource tank;
    
    void Start()
    {
       tank = GetComponent<AudioSource>();
    }

    void Update()
    {
        MoveTank();
        TurnTank();
        
        
    }
    void MoveTank ()
    {
        // tank.Stop();
        if(!tank.isPlaying) tank.PlayOneShot(tankClip);
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
// tank sound -> https://freesound.org/s/329800/