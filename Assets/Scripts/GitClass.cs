using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Seesaam";
    int myPower = 9040;
    int myNum = 245;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        if (myPower > 9000)
        {
            print("It's up to 9045!!!");
        }

        print("My number is " + myNum + ":))");
    }

    // Update is called once per frame
    void Update()
    {

    }
}