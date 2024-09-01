using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the red object at position (2, 0, 0) with no rotation
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Instantiate the blue object at position (-2, 0, 0) with no rotation
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);

        // Set the frame rate to 60 frames per second
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
