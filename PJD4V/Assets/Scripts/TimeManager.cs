using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
    }
}
