using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IskanjeStevil : MonoBehaviour
{
    int[] Masa = { 3, 5, 6, 7, 8, 9, 0,66,-666 };
    int LevaStran;
    int DesnaStran;
    void Start()
    {

        LevaStran = Masa[0];
        DesnaStran = Masa[0];
        for (int i = 0; i < Masa.Length; i++)
        {
            if (Masa[i] > LevaStran)
                LevaStran = Masa[i];
            else if (Masa[i] < DesnaStran)
                DesnaStran = Masa[i];
        }

        Debug.Log("Najvecja stevilka je: " + LevaStran);
        Debug.Log("Najmansa stevilka je: " + DesnaStran);
    }
}
