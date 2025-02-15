﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : StateMachineBehaviour {

    public AudioClip soundEffect;
    AudioSource audioScource;
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        audioScource = animator.gameObject.GetComponent<AudioSource>();
        if(stateInfo.IsName("running")){
            audioScource.loop = true;
            audioScource.volume = 0.8f;
            audioScource.clip = soundEffect;
            audioScource.Play();
        } else {
            audioScource.PlayOneShot(soundEffect, 0.8f);
        }       
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //Debug.Log("Stop Running");
        audioScource.Stop();
        audioScource.clip = null;
        //audioScource.loop = false;
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
