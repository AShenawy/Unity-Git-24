using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Git";
    int myPower = 9000;
    int myPoints = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);

        myPower++;
        if (myPower > 9000)
        {
            print("It's over 9000!!!");
            print("It's " + myPower + ", and your points are " + myPoints);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (myPoints < 9000)
                myPoints++;
        else if (myPoints == 9000)
        {
            print("It's over 9000!!!");
            myPoints++;
        }
    }
}