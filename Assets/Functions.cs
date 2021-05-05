using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WelcomePlayer("June", 20);
        WelcomePlayer("Harry", 26);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WelcomePlayer(string playerName, int age)
    {
        print("Hello Player");
        print("Your name is "+playerName);
        print("You are "+age+" years old");
    }

    int Add(int num1, int num2)
    {
        int additionResult = num1 + num2;
        return additionResult;
    }
}
