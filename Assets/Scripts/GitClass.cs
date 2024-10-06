using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Slim Shady";
    int myPower = 9001;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is who. May name is what. My name is wikawika" + myName);

        if (myPower > 9000)
        {
            print("It's over 9000!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}