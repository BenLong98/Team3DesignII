using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitching : MonoBehaviour {

    [SerializeField] GameObject player;

    [SerializeField] GameObject[] levels = new GameObject[4];
    [SerializeField] GameObject mainSideCam;

    [SerializeField] Vector3 playerSpawnPos;

    private void Start()
    {
        playerSpawnPos = player.transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            
            other.gameObject.GetComponent<PlayerController>().currentLevel++;
            SwitchLevel();
        }
    }

    private void SwitchLevel() {

        switch (player.GetComponent<PlayerController>().currentLevel) {
            case 1:
                ClearLevels();
                levels[0].SetActive(true);
                player.transform.position = playerSpawnPos;
                break;
            case 2:
                ClearLevels();
                levels[1].SetActive(true);
                player.transform.position = playerSpawnPos;
                break;
            case 3:
                ClearLevels();
                levels[2].SetActive(true);
                player.transform.position = playerSpawnPos;
                break;
            case 4:
                ClearLevels();
                levels[3].SetActive(true);
                player.gameObject.SetActive(false);
                mainSideCam.gameObject.SetActive(false);

                break;

            default:
                break;
        }
    }


    private void ClearLevels() {
        for (int i = 0; i < levels.Length; i++) {
            levels[i].SetActive(false);
        }
    }


}
