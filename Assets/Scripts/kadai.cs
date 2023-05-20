using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour
{
    int[] array = { 2, 3, 5, 7, 11 };

    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
}
