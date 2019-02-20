﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpSpeed = 8.0f;
    [SerializeField] float gravityMutli;
    [SerializeField] float gravity = 20.0f;


    [SerializeField] GameObject batModel, playerModel;
    [SerializeField] GameObject particleTransferPrefab;

    private bool isBat = false, isSwitching = false;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    IEnumerator StartSwitchModels() {
        isSwitching = true;
        

        GameObject particle = Instantiate(particleTransferPrefab, this.gameObject.transform);
        Destroy(particle, 1.5f);
        yield return new WaitForSeconds(1.5f);
        SwitchModels();
        isSwitching = false;
    }

    void LateUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            StartCoroutine("StartSwitchModels");
           
        }

        if (!isBat)
        {
            if (controller.isGrounded)
            {
                // We are grounded, so recalculate
                // move direction directly from axes

                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection = moveDirection * speed;


            }
        }
        else {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
        }

        // Apply gravity
        if (!isBat)
        {
            moveDirection.y = moveDirection.y - (gravity * Time.deltaTime * gravityMutli);
        }
        else {
        }
        if (isSwitching == false) {
            // Move the controller
            controller.Move(moveDirection * Time.deltaTime);
        }

    }


    void SwitchModels() {

        if (!isBat)
        {
            batModel.SetActive(true);
            playerModel.SetActive(false);

            //Reset the height of the collider
            controller.height = 1.0f;
            controller.center = new Vector3(0f, 1.6f, 0f);

            isBat = true;
        }
        else if (isBat) {
            batModel.SetActive(false);
            playerModel.SetActive(true);

            controller.height = 2.0f;
            controller.center = new Vector3(0f, 0f, 0f);

            isBat = false;
        }
    }




}
