using UnityEngine;
using System.Collections;

public class GameOverSingleton : Singleton<GameOverSingleton> {
    protected GameOverSingleton() {}

    public bool GameOver = false;
}
