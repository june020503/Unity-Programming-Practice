using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] myFriendsNames = new string[3] { "Tim", "John","Mark" };
    int[] myFriendsAges = new int[3] { 20, 21, 22 };

    int[] myIntArray = new int[4] { 5, 20, -5, -25 };

    // Start is called before the first frame update
    void Start()
    {
        PrintFriendsinformations(0);
        PrintFriendsinformations(1);
        PrintFriendsinformations(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrintFriendsinformations(int myIndex)
    {
        print("My friend is called " + myFriendsNames[myIndex] + " and he is " + myFriendsAges[myIndex]);
    }
}
