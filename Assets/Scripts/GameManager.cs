using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    private bool isGameOver = false;
    public bool GameOver {
        get {
            return isGameOver;
        }
        set {
            isGameOver = value;
            Debug.Log("Game Over!");
        }
    }

    private void Awake() {
        Instance = this;
    }
}