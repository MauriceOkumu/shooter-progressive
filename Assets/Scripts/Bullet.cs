using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //bullet
    public GameObject bullet;
    public Camera topcam;
    public Transform attackPoint;
    //bullet force
    public float shootForce, upwardForce, xPos = 0.5f,yPos = 0.46f,zPos;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Unleash();
    }

    private void Unleash()
    {
      if(Input.GetButtonDown("Fire1")) Shot();
    }

    private void Shot()
    {
        Ray ray = topcam.ViewportPointToRay(new Vector3(xPos, yPos, zPos));
        RaycastHit hit;

        Vector3 target;

        if(Physics.Raycast(ray, out hit)) target = hit.point;
        else target = ray.GetPoint(70);

        Vector3 direction = target - attackPoint.position;

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);
        currentBullet.transform.forward = direction.normalized;
        
         Debug.Log(direction.normalized * -shootForce);

        //Add force to the bullet
        currentBullet.GetComponent<Rigidbody>().AddForce(direction.normalized * -shootForce, ForceMode.Impulse);
    }
}
