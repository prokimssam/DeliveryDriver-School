using System;
using UnityEngine;

public class Operator : MonoBehaviour
{
    private void Start()
    {
        ex1();
        ex2();
    }

    private void ex2()
    {
        
    }

    private static void ex1()
    {
        int score = 100;

        if (score >= 90)
        {
            Debug.Log("���! A+�Դϴ�!");
        }
    }
}
