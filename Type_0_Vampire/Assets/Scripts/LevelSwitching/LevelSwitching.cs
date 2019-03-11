using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitching : MonoBehaviour {

    [SerializeField] GameObject player;

    [SerializeField] GameObject[] levels = new GameObject[4];
    [SerializeField] GameObject mainSideCam;

    [SerializeField] Vector3 playerSpawnPos;
    [SerializeField] AudioSource masterSource;
    [SerializeField] AudioClip DanceMusic;
    [SerializeField] GameObject gatheredImageUI;
    [SerializeField] GameObject EndGamePanel;
    [SerializeField] GameObject Dancer;

    private void Start()
    {
        playerSpawnPos = player.transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            
            other.gameObject.GetComponent<PlayerController>().currentLevel += 1;
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
                LoadDanceLevel();
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

    public void LoadDanceLevel() {
        ClearLevels();
        levels[3].SetActive(true);
        gatheredImageUI.SetActive(false);
        Dancer.GetComponent<DanceHandler>().SetScore();
        EndGamePanel.SetActive(true);
        player.gameObject.SetActive(false);
        mainSideCam.gameObject.SetActive(false);
        masterSource.clip = DanceMusic;
        masterSource.Play();
    }


}
