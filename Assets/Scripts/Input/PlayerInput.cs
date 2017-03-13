﻿using UnityEngine;
using System.Collections;

using InControl;

public class PlayerInput : BaseInput {

    //was getting null ref on this sorry you can replace this it just didnt work calling the class directly
//    NPInputManager thisNPInputManager;

    private void Start()
    {
//        thisNPInputManager = GetComponent<NPInputManager>();
    }
    
	void Update () {
		shoot = NPInputManager.input.Fire.WasPressed;
		aim = NPInputManager.input.Aim.IsPressed;
		lookDir = NPInputManager.input.Look;

		if(aim) {
			moveDir = Vector3.zero;
			sprint = false;
			melee = NPInputManager.input.Melee.WasPressed;
		} else {
			moveDir = new Vector3(NPInputManager.input.Move.X, 0f, NPInputManager.input.Move.Y); //its an x,y vec EW
			sprint = NPInputManager.input.Sprint;
			melee = false;
		}
	}
}
