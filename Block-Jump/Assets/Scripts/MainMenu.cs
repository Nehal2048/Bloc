using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    public static int gameMode;

    //Main Menu
    public void QuitGame()
    {
        Application.Quit();
    }


    //OPTIONS
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    //GameMode
    public void GameMode()
    {
        gameMode = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PracticeMode()
    {
        gameMode = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
