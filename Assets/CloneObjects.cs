using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{
    int i;
    public GameObject objectToClone;
    public void InstatiateObject()
    {
        while (i != 3) {
            Instantiate(objectToClone);
            i++;

        }
        i = 0;
    }
}
