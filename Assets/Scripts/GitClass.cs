using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Galina";
    int myPower = 9001;

    // Start is called before the first frame update
    void Start()
    {
        print("I have no idea if it works, will check on class PC. Also, hello! My name is " + myName);

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