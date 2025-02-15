using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationScript : MonoBehaviour
{
    public GameObject panel;
    private bool isInfoActive = false;
    public void ButtonClicked()
    {
        isInfoActive = !isInfoActive;
        panel.SetActive(isInfoActive);
    }
}