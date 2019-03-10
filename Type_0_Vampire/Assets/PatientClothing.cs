using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientClothing : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PutClothesOn();
	}

    void PutClothesOn() {
        Transform bodyTransform = this.transform.Find("main_body1_Untitled.002");


        bodyTransform.gameObject.GetComponent<SkinnedMeshRenderer>().material.color = GetColor();

    }

    private Color GetColor() {
        switch (Random.Range(1, 8)) {
            case 1:
                return Color.blue;
            case 2:
                return Color.red;
            case 3:
                return Color.yellow;
            case 4:
                return Color.magenta;
            case 5:
                return Color.green;
            case 6:
                return Color.cyan;
            case 7:
                return Color.grey;
            default:
                return Color.grey;
        }
    }
}
