using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] ParticleSystem muzzleFlash;

    void Start()
    {
        
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
    }
}
