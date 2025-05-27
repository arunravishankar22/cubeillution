using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camc : MonoBehaviour
{
    public float SpeedH = 2.0f, SpeedV = 2.0f;

    private float yaw = 0f, pitch =0f;

    public float getH= 35.2560f, getV= -45f;


    void Start()
    {
        //transform.eulerAngles = new Vector3(35.2560f, 315f, -1.04554647e-06f);
    }

    // Update is called once per frame
    void Update()
    {
        //yaw += SpeedH * getH;
        //pitch -= SpeedV * getV;

        transform.eulerAngles = new Vector3(getH, getV, 0.0f); 
    }

    public void sliderHori( float h)
    {
        getH = h;
    }

    public void sliderVer(float v)
    {
        getV= v;
    }
}
