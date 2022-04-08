using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;
using UnityEngine.UI;

public class ColliderManager : MonoBehaviour
{
    static Stopwatch stopWatch = new Stopwatch();
    public Text timer;

    public void OnTriggerEnter(Collider other)

    {

        if (other.name == "startpoint")
        {

            stopWatch.Start();
        }
        if (other.name == "endpoint")
        {  
            stopWatch.Stop();
            string elapsedtime = stopWatch.Elapsed.ToString();

            timer.text = $"Game over! Maze Successfully Completed Elapsed Time: {elapsedtime}";



        }
    }
}