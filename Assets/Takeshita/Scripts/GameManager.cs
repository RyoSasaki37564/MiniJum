using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameManager
{
    private static int _highScore;
    private static int _killedEnemy;
    private static event Action _onGameFinish;

    public static int HighScore { get => _highScore; private set => _highScore = value; }
    public static int KilledEnemy { get => _killedEnemy; set => _killedEnemy = value; }

    public static event Action OnGameFinish { add { _onGameFinish += value; } remove { _onGameFinish -= value; } }

    public static void GameFinish()
    {
        Time.timeScale = 0;
        if(KilledEnemy > HighScore)
        {
            HighScore = KilledEnemy;
        }

        _onGameFinish();
    }

    public static void Init()
    {
        KilledEnemy = 0;
    }
}
