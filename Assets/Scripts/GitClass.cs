using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitClass : MonoBehaviour
{
    string myName = "raccoon";
    int cookies = 1;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello! My name is " + myName);
        while (true)
        {

             if (cookies <= 5)
            {
                print("eu gosto disso");
            }
            else if (cookies <= 10)
            {
                print("gonna steal your cookies later");
            }
            else if (cookies <= 15)
            {
                print("MINE");
            }
            if (cookies > 20)
            {
                break;
            }
            cookies++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}