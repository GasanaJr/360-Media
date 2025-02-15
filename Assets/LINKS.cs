using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LINKS : MonoBehaviour
{
    public void OpenLink()
    {
        Application.OpenURL("https://www.alueducation.com/home/about-alu/");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
