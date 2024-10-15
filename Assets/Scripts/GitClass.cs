using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Miky";
    int myPower = 42;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        if (myPower == 42)
        {
            print("The Answer to Ultimate Question of Life, the Universe and Everything is 42.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}