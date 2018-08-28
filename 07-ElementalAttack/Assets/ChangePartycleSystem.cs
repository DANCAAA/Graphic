using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePartycleSystem : MonoBehaviour
{
    ParticleSystem ps;
    public float speed;
    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward*(-1) * Time.deltaTime, Camera.main.transform);
        var emision = ps.emission;
        var shape = ps.shape;
        
        
	}
}
