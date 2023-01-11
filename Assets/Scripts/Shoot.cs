using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] ParticleSystem muzzleFlash;
    // [SerializeField] AudioClip shotClip;
    //  AudioSource asource;
    

    void Start()
    {
        //  asource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) Flash();
    }

    private void Flash()
    {
        PlayMuzzleFlash();
    }

    private void PlayMuzzleFlash()
    {
      muzzleFlash.Play();
    //    if(!asource.isPlaying) asource.PlayOneShot(shotClip);
    }

}
