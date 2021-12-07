using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string level = "Level-1"; //Placeholder!!!
    private void Awake() {
        GameManager.GameStateChanged += StateChanged;
    }

    public void OnDestroy() {
        GameManager.GameStateChanged -= StateChanged;

    }

    public void StateChanged(GameState state)
    {
       if(state == GameState.StartLevel)
       {
            startGame();
       }
    }

    public void startGame()
    {
        SceneManager.LoadScene(level);
    }


}