using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public int total;
    public int Rtot;
    public int Ptot;
    public int Stot;
    // Update is called once per frame
    void Update()
    {
        Rtot = GameObject.FindGameObjectsWithTag("rock").Length;
        Ptot = GameObject.FindGameObjectsWithTag("paper").Length;
        Stot = GameObject.FindGameObjectsWithTag("scissors").Length;
        total = Rtot + Ptot + Stot;
    }
}
