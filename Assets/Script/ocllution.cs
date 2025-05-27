using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocllution : MonoBehaviour
{
    public Camera came;

    void Start()
    {

        came = this.transform.GetChild(0).GetComponent<Camera>();
        if (came.useOcclusionCulling==true)
        {
            came.useOcclusionCulling = false;
            
        }
        else
            came.useOcclusionCulling = true;
    }

    private void Update()
    {
        
    }
}
