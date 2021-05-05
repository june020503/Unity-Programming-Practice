using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    int myAge = 20;
    int minAge = 19;

    bool isVIP = false;
    bool roomIsFull = false;
    // Start is called before the first frame update
    void Start()
    {
        if(myAge>=minAge && roomIsFull==false || isVIP==true)
        {
            print("Pass");
        }
        else if()
        {

        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
