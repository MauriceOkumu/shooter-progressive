using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Score score;
    [SerializeField] ParticleSystem explosion;
    // RigidBody rb;
    // float thrust = 100;
    void Start()
    {
        score = FindObjectOfType<Score>();

    }

    private void OnCollisionEnter(Collision other) {
      score.updateScore(15);
      explosion.Play();
    }

    // void ProcessShot()
    // {
    //     rb.AddRelativeForce(Vector3.forward * thrust * Time.deltaTime);
    // }
}
