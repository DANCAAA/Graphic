using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControler : MonoBehaviour
{
    [SerializeField]
    Gradient colorGradient;

    float t = 0;
    Light mLight;
    ParticleSystem mParticleSys;
    ParticleSystem.MainModule mParticleMain;

	// Use this for initialization
	void Start ()
    {
        mLight = GetComponent<Light>();
        mParticleSys = GetComponentInChildren<ParticleSystem>();
        mParticleMain = mParticleSys.main;
	}
	
	// Update is called once per frame
	void Update ()
    {
        t += Time.deltaTime;
        mLight.color = colorGradient.Evaluate(t / 6);
        mParticleMain.simulationSpeed = 0.5f;
	}
}
