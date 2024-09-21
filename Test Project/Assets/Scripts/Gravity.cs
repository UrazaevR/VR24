using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gravity : MonoBehaviour
{
    public GameObject Plane;
    float z;
    int i = 0;
    public Vector3 g = new Vector3(0, (float) -0.01, 0);
    public Vector3 Speed = new Vector3(0, 0, 0);
    public Vector3 Jump_Boost = new Vector3(0, (float) 0.3, 0);
    public Vector3 size;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        size = renderer.bounds.size;
    }

    void Gravity_update()
    {
        Speed += g;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.gameObject.transform.position.y - size.y / 2 <= Plane.transform.position.y) {
            Speed = Jump_Boost;
            i++;
            Jump_Boost.y *= (float) 1;
        }
        this.gameObject.transform.Translate(Speed);
        z = this.gameObject.transform.position.z;
        //Debug.Log(z);
        Gravity_update();
    }
}
