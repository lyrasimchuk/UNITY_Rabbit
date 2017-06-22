using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : Collectables {
	protected override void OnRabitHit (HeroRabit rabit) {
		this.CollectableHide ();
		LevelController.current.addFruits(1);
	}}
