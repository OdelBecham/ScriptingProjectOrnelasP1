using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemerature = 40.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot");
        }
        else if (coffeeTemperature < coldLimitTemerature)
        {
            print("Coffee is too Cold");
        }

        else
        {
            print("Coffee is just right");
        }
    }
}
