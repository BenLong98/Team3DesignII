using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DanceHandler : MonoBehaviour {

	[SerializeField] GameObject nurseDancer;
    [SerializeField] GameObject player;

    [SerializeField] Text nurseScore;
    [SerializeField] Text playerScore;

    [SerializeField] int total;
    [SerializeField] int totalNurse;



    public void SetScore()
    {
        //Set player stats

        for (int i = 0; i < player.GetComponent<PlayerController>().collectedDances.Count; i++)
        {
            total = total + player.GetComponent<PlayerController>().collectedDances[i];
        }

        playerScore.text = "Score : " + total;

       


    }

    public void SetNurseScore() {
        for (int i = 0; i < nurseDancer.GetComponent<DancingNurse>().danceMoves.Length; i++)
        {
            totalNurse = totalNurse + nurseDancer.GetComponent<DancingNurse>().danceMoves[i];
        }

        nurseScore.text = "Score : " + totalNurse;
    }



}
