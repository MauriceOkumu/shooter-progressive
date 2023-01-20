using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cameras : MonoBehaviour
{
    public CinemachineVirtualCamera mainCam;
    public CinemachineVirtualCamera cockpitCam;
    bool changed = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
          ChangeCamera();
        }
    }

    void ChangeCamera(){
        if(changed) {
            mainCam.Priority = 20;
        } else {
             mainCam.Priority = 5;
        }
        changed = !changed;

    }
}
