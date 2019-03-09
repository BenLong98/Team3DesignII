using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentCollision : MonoBehaviour {

    [SerializeField] GameObject directionText;
    [SerializeField] GameObject controller;

    [SerializeField] bool canEnter = false;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject leftCam, rightCam;

    [SerializeField] bool isInVent = false;

    [SerializeField] GameObject controlText;


    public void Start()
    {
        controller = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            if (controller.GetComponent<PlayerController>().GetIsBat() == true)
            {
                directionText.SetActive(true);
                canEnter = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            directionText.SetActive(false);
            canEnter = false;
        }
    }

    private void Update()
    {
        if (canEnter && Input.GetKeyDown(KeyCode.E)) {
            controller.SetActive(false);
            mainCam.SetActive(false);
            isInVent = true;
            directionText.SetActive(false);

            //Set the cam to false
            leftCam.SetActive(false);
            rightCam.SetActive(true);

        }


        if (isInVent && Input.GetKeyDown(KeyCode.F))
        {
            controller.SetActive(true);
            mainCam.SetActive(true);
            leftCam.SetActive(false);
            rightCam.SetActive(false);

            isInVent = false;
            controlText.SetActive(false);

        }



        if (isInVent == true)
        {
            controlText.SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow) && isInVent) {
            leftCam.SetActive(true);
            rightCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && isInVent)
        {
            leftCam.SetActive(false);
            rightCam.SetActive(true);
        }
    }
}
