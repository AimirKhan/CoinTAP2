using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSSettings : MonoBehaviour
{
    [SerializeField] private int targetFPS = 60;
    
    void Start()
    {
        Application.targetFrameRate = targetFPS;
    }
}
