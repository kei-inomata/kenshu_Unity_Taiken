using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public static float countTime2 = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime2 += Time.deltaTime;
        GetComponent<Text>().text = countTime2.ToString("F2");
    }
    public static float gettime()
    {
        return countTime2;
    }
}
