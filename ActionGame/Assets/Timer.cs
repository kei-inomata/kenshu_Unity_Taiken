using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour
{
    // Start is called before the first frame update
    public static float countTime1 = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime1 += Time.deltaTime;
        GetComponent<Text>().text = countTime1.ToString("F2");
    }
    public static float gettime()
    {
        return countTime1;
    }
}
