using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "Git";
    int myPower = 9016;
    string myPic = "tornado";

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! Minu nimi on " + myName);

        if (myPower > 9000)
        {
            print("It's over 9000!!!");
        }

        print("I added the picture " + myPic);
    }

    // Update is called once per frame
    void Update()
    {

    }
}