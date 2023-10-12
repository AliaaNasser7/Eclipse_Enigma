using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Vector3 offset;
    public KeplerCelestial earth;
    void Start()
    {
        if(earth == null)
        {
            if(GameObject.Find("Earth") != null)
            {
                earth = GameObject.Find("Earth").GetComponent<KeplerCelestial>();
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Earth"))
            return;
        else
        {
            earth = GameObject.Find("Earth").GetComponent<KeplerCelestial>();
        }

        transform.position = earth.transform.position + offset;
    }
}
