using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Risult : MonoBehaviour
{
    private static List<float> times = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        times.Add(Scene_change.time1);
        times.Add (goal.time2);
        Debug.Log(times[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
