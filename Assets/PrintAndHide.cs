using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 3; // Initialize i to 3
    }

    // Update is called once per frame
    void Update()
    {
        i++; // Increment i by 1 at the start of every frame
        Debug.Log(gameObject.name + ":" + i); // Print GameObject's name and the value of i

    }
}
