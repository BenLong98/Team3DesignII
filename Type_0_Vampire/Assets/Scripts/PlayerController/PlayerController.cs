using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpSpeed = 8.0f;
    [SerializeField] float gravityMutli;
    [SerializeField] float gravity = 20.0f;


    [SerializeField] GameObject batModel, playerModel;
    [SerializeField] GameObject particleTransferPrefab;

    [SerializeField] GameObject mainCam;

    [SerializeField] int amountOfDancesfoundperBag = 1;

    private bool isBat = false, isSwitching = false;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    [SerializeField] Animator myAnim;

    [SerializeField] GameObject gatherbloodText;


    public bool GetIsBat() {
        return isBat;
    }


    void Start()
    {

        controller = GetComponent<CharacterController>();
        myAnim = playerModel.GetComponent<Animator>();
    }

    IEnumerator StartSwitchModels() {
        isSwitching = true;
        

        GameObject particle = Instantiate(particleTransferPrefab, this.gameObject.transform);
        particle.transform.position = playerModel.transform.position;
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
                moveDirection = moveDirection * speed;

                Vector3 facingrotation = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
                if (facingrotation == Vector3.zero)         //This condition prevents from spamming "Look rotation viewing vector is zero" when not moving.
                    facingrotation = transform.forward;

                transform.rotation = Quaternion.LookRotation(facingrotation);

                if (moveDirection != Vector3.zero)
                {
                    myAnim.SetBool("Movement", true);
                }
                else {
                    myAnim.SetBool("Movement", false);
                }





            }
        }
        else {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = moveDirection * speed;


            Vector3 facingrotation = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
            if (facingrotation == Vector3.zero)         //This condition prevents from spamming "Look rotation viewing vector is zero" when not moving.
                facingrotation = transform.forward;

            transform.rotation = Quaternion.LookRotation(facingrotation);

          

        }

        // Apply gravity
        if (!isBat)
        {
            moveDirection.y = moveDirection.y - (gravity * Time.deltaTime * gravityMutli);
            if (Input.GetKeyDown(KeyCode.C)) {
                Debug.Log("YOO OYOO");
            }
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
            controller.center = new Vector3(0f, 0.98f, 0f);

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



    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "BloodBag")
        {
            //enable text directions
            gatherbloodText.SetActive(true);

            if (other.gameObject.GetComponent<BloodCollection>().gatheredAlready == true) {
                gatherbloodText.SetActive(false);
            }


            if (Input.GetKeyDown(KeyCode.E) &&
                other.gameObject.GetComponent<BloodCollection>().amountOfUses > 0)
            {
                other.gameObject.GetComponent<BloodCollection>().amountOfUses--;
                other.gameObject.GetComponent<BloodCollection>().gatheredAlready = true;
                Debug.Log("Gathered");
            }
            else if (Input.GetKeyDown(KeyCode.E) && other.gameObject.GetComponent<BloodCollection>().amountOfUses <= 0)
            {
              
                Debug.Log("Already Gathered");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "BloodBag")
        {
            //disable text for bloodbag
            gatherbloodText.SetActive(false);
        }
    }


}
