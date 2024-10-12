using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Git";
    int myPower = 9001;
    int powerReduction = 50;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        if (myPower > 9000)
        {
            print("It's over 9000!!!");
            myPower -= powerReduction;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(myPower > 8000)
        {
            print("My power is still greater than 8000");
            myPower -= powerReduction;
        }
    }
}