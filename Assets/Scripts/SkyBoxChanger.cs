using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public Material sky1;
    public Material sky2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSky1()
    {
        RenderSettings.skybox = sky1;
    }
    public void SetSky2()
    {
        RenderSettings.skybox = sky2;
    }
}
