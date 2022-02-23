using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectReferencingInstance : MonoBehaviour
{

    [SerializeField] private Material[] skyboxList;


    public void OnClickChangeSkybox(int skyboxID)
    {
        RenderSettings.skybox = skyboxList[skyboxID];
    }


    public void OnClickFreeMemory()
    {
        GC.Collect();
    }
}
