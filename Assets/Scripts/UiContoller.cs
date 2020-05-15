using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class UiContoller : MonoBehaviour
{


    public Animator startButton;
    public Animator infoButton;
    public Animator exitButton;
    public Animator infoPanel;


    private void Start()
    {

    }


    public void startGame()
    {
        SceneManager.LoadScene("Roll-a-ball");
    }

    public void quitGame()
    {
        Application.Quit();
    }
    public void startScreen()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void information()
    {
        bool isHidden = infoPanel.GetBool("isHidden");

        infoPanel.SetBool("isHidden", !isHidden);
        infoButton.SetBool("isHidden", !isHidden);
        exitButton.SetBool("isHidden", !isHidden);
        startButton.SetBool("isHidden", !isHidden);
    }

}
