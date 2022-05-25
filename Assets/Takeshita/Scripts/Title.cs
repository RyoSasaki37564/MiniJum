using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField, Tooltip("ハイスコアのテキスト")]
        Text _highScoreText;

    private void Start()
    {
        _highScoreText.text = $"High Score  {GameManager.HighScore}";
        GameManager.Init();
    }

    public void OnClick()
    {
        Debug.Log("ゲームスタート");
        //SceneManager.LoadScene(1);
    }
}
