using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class ControlAI : MonoBehaviour {

    [SerializeField] Animator myAnim;


	// Use this for initialization
	void Start () {
        myAnim = this.GetComponent<Animator>();


      RandomGesture();
	}

    void RandomGesture() {
        int x = Random.Range(1, 100);
        if (x > 90) {
            myAnim.SetTrigger("Cough");
        }

        Invoke("RandomGesture", 1f);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
