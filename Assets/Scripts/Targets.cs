using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public Transform explosion;
    public ParticleSystem destroyed;
    public Transform spawnPoint;
    AudioSource asource;
    int hit = 0;
    ContactPoint contact;
         Quaternion rotation;
         Vector3 position;

    void Start()
    {
         asource = GetComponent<AudioSource>();
    }
    
    private void OnCollisionEnter(Collision collision) {
        
        
        if(collision.gameObject.tag == "Shot") {
            
        GetComponent<MeshRenderer>().material.color = Color.red;
     

         contact = collision.contacts[0];
         rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
         position = contact.point;
         Instantiate(explosion, position, rotation);
         asource.Play();
        hit++;
      }
     if(hit > 2) {
        // destroyed.Play();
        Instantiate(destroyed, spawnPoint.position, Quaternion.identity);
        Destroy(gameObject);
    }
    }
}
