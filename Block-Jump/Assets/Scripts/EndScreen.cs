using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text scoreText;
    public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = Score.score.ToString();
        HighScoreText.text = Score.score.ToString();
        Time.timeScale = 0f;
        PauseMenu.GameIsPaused = true;
        CameraFollow.cameraActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.score.ToString();
        HighScoreText.text = Score.score.ToString();
    }


    public void QuitGameButton()
    {
        Application.Quit();
    }

    public void PlayButton()
    {
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
        CameraFollow.cameraActive = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }

}
