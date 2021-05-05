using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // my variables
    int health = 5;
    float speed = 3.5f;
    string charactername = "starwhale";
    bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
        print(health);
        print("hello my name is " + charactername);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
