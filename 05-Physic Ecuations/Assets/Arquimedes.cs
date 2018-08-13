using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arquimedes : MonoBehaviour
{
    [SerializeField]
    public float InitialRadious;

    [SerializeField]
    public float InitialAngu;


    [SerializeField]
    public float w;

    [SerializeField]
    public float vy;

    [SerializeField]
    public float GrowVelocity;

    float t = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float r = t;
        t += Time.deltaTime;
        float x = r * Mathf.Cos(w * t);
        float z = r * Mathf.Sin(w * t);
        float y = t;
        Vector3 pos = new Vector3(x, y, z);
        transform.localPosition = pos;
    }
}
