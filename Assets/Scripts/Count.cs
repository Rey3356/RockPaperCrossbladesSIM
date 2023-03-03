using System;
using UnityEngine;
using UnityEngine.UI;
using Unity;


public class Count : MonoBehaviour
{
    [SerializeField] Slider countslide;
    int NoORocks;
    int cR;
    int SVR;
    int NoOPapers;
    int cP;
    int SVP;
    int NoOScissors;
    int cS;
    int SVS;

    private void Start()
    {
     
        cR = GameObject.FindGameObjectsWithTag("rock").Length;
        cP = GameObject.FindGameObjectsWithTag("paper").Length;
        cS = GameObject.FindGameObjectsWithTag("scissors").Length;
    }

    private void Update()
    {
        NoORocks = GameObject.FindGameObjectsWithTag("rock").Length;
        if (NoORocks > 0 && NoORocks <= 310)
        {
            int SVR = Convert.ToInt32(countslide.normalizedValue * NoORocks);
                cR = 3 + SVR;
                Debug.Log("3 + current no of rocks*slidevalue("+SVR+") =" + cR);
        }
        else
        {
            cR = 300;
        }
        Debug.Log("Final"+cR);
    }
}
