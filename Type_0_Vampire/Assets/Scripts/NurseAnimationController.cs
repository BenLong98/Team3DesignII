using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class NurseAnimationController : MonoBehaviour {

    [SerializeField] GameObject playerModel;
    [SerializeField] Animator nurseAnim;


    private void Start()
    {
        nurseAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (playerModel.GetComponent<NavMeshAgent>().velocity.magnitude > 0.0)
        {
            nurseAnim.SetBool("isMoving", true);
        }
        else {
            nurseAnim.SetBool("isMoving", false);
        }
    }

}
