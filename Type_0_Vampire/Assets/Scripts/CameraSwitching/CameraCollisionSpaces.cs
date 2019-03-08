using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollisionSpaces : MonoBehaviour {

    [SerializeField] GameObject[] camerasInLevel;
    [SerializeField] int cameraCount = 0;
    

    private void Start()
    {
        camerasInLevel = GameObject.FindGameObjectsWithTag("RoomCamera");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            SwitchCamera();
        }
    }


    private void SwitchCamera() {

        if (cameraCount % 2 == 0)
        {
            for (int i = 0; i < camerasInLevel.Length; i++)
            {
                if (camerasInLevel[i].GetComponent<CameraProperties>().GetCamNumber() == this.gameObject.GetComponent<CameraProperties>().GetCamNumber())
                {
                    camerasInLevel[i].GetComponent<Camera>().enabled = true;
                    cameraCount++;
                }
                else
                {
                    camerasInLevel[i].GetComponent<Camera>().enabled = false;
                }
            }
        }
        else {
            for (int i = 0; i < camerasInLevel.Length; i++) {
                camerasInLevel[i].GetComponent<Camera>().enabled = false;
                cameraCount++;
            }
        }

    }

}

