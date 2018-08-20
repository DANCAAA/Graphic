using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    Gradient colorGradient;
    //configuracion curva
    [SerializeField]
    AnimationCurve intensityOvertime;
    //
    float t = 0;
    Light mLight;
    ParticleSystem mParticleSys;
    //vfxx controller
    public GameObject player;
    Animator anima;
    //
    ParticleSystem.MainModule mParticleMain;
    float duration;
    public float speed;


    // Use this for initialization
    void Start ()
    {
        // get component imparent animatorvfx controller
        anima = player.GetComponent<Animator>();

        mLight = GetComponent<Light>();
        mParticleSys = GetComponentInParent<ParticleSystem>();
        mParticleMain = mParticleSys.main;
        duration = mParticleMain.duration;

        // get component imparent animator vfx controller
        GetComponentInParent<LightController>().speed = speed;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //cambiar velocidad animacion y sistemas de particulas vfx controller
        mParticleMain.simulationSpeed = speed;
        anima.speed = speed;
        //
        t += (Time.deltaTime * speed) / duration ;
        mLight.color = colorGradient.Evaluate(t);

        //Intensidad luz
        mLight.intensity = intensityOvertime.Evaluate(t);
        ///
        
    }
}
