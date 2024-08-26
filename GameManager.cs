using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameOverScreen;

    void Update()
    {
        if (Input.anyKeyDown && startScreen.activeSelf)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        startScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

