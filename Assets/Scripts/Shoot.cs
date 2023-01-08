using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem muzzleFlash;

    void Start()
    {
        
    }

    // Update is called once per frame
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
