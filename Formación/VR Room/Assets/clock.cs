using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour

{
    private Transform Clock_Analog_a_Hour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current hour (0-23)
        int hour = DateTime.Now.Hour;

        // Convert the hour to a value from 0-12
        if (hour > 12)
        {
            hour -= 12;
        }

        // Calculate the rotation for the hour hand
        // Each hour is 30 degrees (360 degrees / 12 hours)
        float rotation = 30f * hour;
        // Apply the rotation to the hour hand
        Clock_Analog_a_Hour = transform.Find("Clock_Analog_a_Hour").GetComponent<Transform>();
        Clock_Analog_a_Hour.localRotation = Quaternion.Euler(0f, 0f, -rotation);
    }
}
