using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakenFlight : MonoBehaviour
{
    public IntData flightAmount;
    public int newFlightAmount;

    public void OnTriggerEnter(Collider other)
    {
        flightAmount.value = newFlightAmount;
    }
}
