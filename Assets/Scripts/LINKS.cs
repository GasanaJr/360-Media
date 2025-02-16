using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LINKS : MonoBehaviour
{
    public void openLink()
    {
        Application.OpenURL("https://www.alueducation.com/home/about-alu/");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadOutro()
    {
        SceneManager.LoadScene(2);
    }
}
