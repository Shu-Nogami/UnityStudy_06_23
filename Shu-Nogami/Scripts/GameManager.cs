using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerUI playerUI;

    public void Defeat(){
        playerUI.SetText("Defeat");
        Invoke("GameEnd", 5f);
    }
    public void Victory(){
        playerUI.SetText("Victory");
        Invoke("GameEnd", 5f);
    }
    void GameEnd(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
