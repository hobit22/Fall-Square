using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePose = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePose.x, mousePose.y, 0);
    }
}
