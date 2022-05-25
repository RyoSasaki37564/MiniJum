using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] Text _score;
    [SerializeField] Text _highScore;

    private void OnEnable()
    {
        _score.text = GameManager.KilledEnemy.ToString();
        _highScore.text = GameManager.HighScore.ToString();
    }

    public void OnClick()
    {
        Debug.Log("タイトル画面へ");
        //SceneManager.LoadScene(0);
    }
}
