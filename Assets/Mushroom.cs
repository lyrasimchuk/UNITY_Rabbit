using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Collectables {

    protected override void OnRabitHit(HeroRabit rabit)
    {
        rabit.getBigger();
		this.CollectableHide ();
    }
}
