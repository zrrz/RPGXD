using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	BaseInput input;
	CharacterController characterController;
	public float moveSpeed = 2f;
	Animator animator;

	void Start () {
		input = GetComponent<BaseInput>();
		characterController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
	}
	
	void Update () {
		characterController.SimpleMove(input.moveDir*moveSpeed);
		bool sprinting = input.sprint;
		animator.SetFloat("MoveSpeed", Mathf.Lerp(animator.GetFloat("MoveSpeed"), Mathf.Clamp01(input.moveDir.magnitude)/2f + (sprinting ? 0.5f : 0f), 10f*Time.deltaTime));

		if(input.melee) {
			animator.SetTrigger("Attack");
		}
	}
}
