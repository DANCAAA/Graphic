using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTime : MonoBehaviour {

    Animator mAnimator;

	void Start () {
        mAnimator = GetComponent<Animator>();

    }
	
	void Update () {
        AnimatorStateInfo state = mAnimator.GetCurrentAnimatorStateInfo(0);
        float time = state.normalizedTime* state.length * state.speed;
        Debug.Log(time);

    }
}
