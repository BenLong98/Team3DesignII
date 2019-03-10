using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDiscoBall : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 1f, 0, Space.World);
    }
}
