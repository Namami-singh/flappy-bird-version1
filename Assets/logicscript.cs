using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore = 0;
    public Text Scoretext;
    public GameObject gameoverscreen;
    [ContextMenu("player score +1")]
    public void addScore(int ScoreToAdd)
    {
        playerscore = playerscore + ScoreToAdd;
        Scoretext.text = playerscore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Gameover()
    {
        gameoverscreen.SetActive(true);
    }
}