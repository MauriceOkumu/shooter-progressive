using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
      
      Destroy(gameObject, 1f);
    }

}
