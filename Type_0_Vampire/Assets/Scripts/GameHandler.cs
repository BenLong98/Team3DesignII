using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameHandler : MonoBehaviour {

    public void OnQuitButton() {
        Application.Quit();
    }

    public void OnPlay() {
        SceneManager.LoadScene(1);
    }


        
}
