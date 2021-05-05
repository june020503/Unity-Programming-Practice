using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 0;
    int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    void Start()
    {
        while(i<=10)
        {
            print(i);
            i++;
        }

        for(int j=0 ; j<=10 ; j++)
        {
            print(j);
        }

        foreach(int currentNumber in numbers)
        {
            print(currentNumber);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
