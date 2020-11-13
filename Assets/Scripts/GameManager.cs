using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
100% mobile compatible

:)

Author: Swarnaditya Singh

Find me on instagram:
https://www.instagram.com/demonkingswarn

Find me on Twitter:
https://www.twitter.com/DemonKingSwarn
 */

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    public int score = 0;
    public bool gameOver = false;
    
    //Every time bird goes through center of the pipe increment score by 1
    public void ScoreIncrement()
    {
        score += 1;
        UIManager.Instance.UpdateScore(score);
    }

    //Notify when game over
    public void GameOver()
    {
        gameOver = true;
        UIManager.Instance.GameOver();  //Notify our UIManager that game is now over so we can display Game Over screen buttons
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
