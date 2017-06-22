using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Collectables {

    protected override void OnRabitHit(HeroRabit rabit)
    {
        rabit.Explode();
		this.CollectableHide ();
    }
}
