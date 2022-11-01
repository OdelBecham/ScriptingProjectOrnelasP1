using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldCountinue = false;
        do
        {
            print("Hello World");
        }
        while (shouldCountinue == true);
    }
}
