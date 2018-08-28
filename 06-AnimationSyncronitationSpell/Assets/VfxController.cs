using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxController : MonoBehaviour
{
    [SerializeField]
    float speed;
    float duration;
    float t = 0;

    // Use this for initialization
    void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        t += speed * Time.deltaTime / duration;
        
        
	}
}
