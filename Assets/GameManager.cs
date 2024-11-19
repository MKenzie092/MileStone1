using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CollectedCoin = 0;
    private bool isPaused = false;

    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;
        Debug.Log(CollectedCoin);
        if (CollectedCoin >= 5)
        {
            Debug.Log("You Won!");
            SceneManager.LoadScene("You Win!");
        }

    }

    void Update()
    {
        Pause();
    }

    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }

            isPaused = !isPaused;

        }
    }
}
