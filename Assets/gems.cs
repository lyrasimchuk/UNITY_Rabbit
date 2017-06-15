using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gems : Collectables {
	protected override void OnRabitHit (HeroRabit rabit) {
		this.CollectableHide ();
		LevelController.current.addGems(1);
	}}
