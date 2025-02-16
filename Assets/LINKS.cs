using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
