using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour
{

    public int fps = 200;
    // Use this for initialization
    void Start()
    {
        QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (fps != Application.targetFrameRate)
        {
            Application.targetFrameRate = fps;
        }
    }
}
