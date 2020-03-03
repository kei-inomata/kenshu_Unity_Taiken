using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stage1 : MonoBehaviour
{
    GameObject goal;
    Scene_change script;
    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.Find("Gola");
        script = goal.GetComponent<Scene_change>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}

