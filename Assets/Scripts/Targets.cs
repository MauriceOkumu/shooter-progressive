using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public Transform explosion;
    public ParticleSystem destroyed;
    public Transform spawnPoint;
    public AudioClip destroyedSound;
    public AudioClip hitSound;
    public Score score;

    AudioSource asource;
    int hit = 0;
    ContactPoint contact;
    Quaternion rotation;
    Vector3 position;

    void Start()
    {
         asource = GetComponent<AudioSource>();
         score = FindObjectOfType<Score>();
    }
    
    private void OnCollisionEnter(Collision collision) {
        
        
        if(collision.gameObject.tag == "Shot") {
            
        GetComponent<MeshRenderer>().material.color = Color.red;
     

         contact = collision.contacts[0];
         rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
         position = contact.point;
         Instantiate(explosion, position, rotation);
        PlaySound(hitSound);
        hit++;
        Globals.target_hit++;
        score.updateScore(Globals.target_hit);
        Destroy(collision.gameObject);
      }
     if(hit > 2) {
        // destroyed.Play();
        Instantiate(destroyed, spawnPoint.position, Quaternion.identity);
        PlaySound(destroyedSound);
        Destroy(gameObject,.8f);
      }
    }

    void PlaySound(AudioClip clip)
    {
         asource.Stop();
         asource.PlayOneShot(hitSound);
    }
}
