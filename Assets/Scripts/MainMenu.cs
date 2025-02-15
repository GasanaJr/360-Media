using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
   // public VideoPlayer videoPlayer;
    //public GameObject videoQuad;
    public GameObject buttonPanel;

    // Start is called before the first frame update
    void Start()
    {
        buttonPanel.SetActive(true);
        //videoPlayer.loopPointReached += EndVideo;

    }

    /*void EndVideo(VideoPlayer vp)
    {
        videoQuad.SetActive(false);
        buttonPanel.SetActive(true);
    }*/

    public void StartTour()
    {
        SceneManager.LoadScene(0);

    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
