using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public static LevelController current;
	int coins = 0;
	int fruits = 0;
	int gems = 0;
	Vector3 startingPosition;
	public float level;
	public void setStartPosition(Vector3 pos){
		this.startingPosition = pos;
	}
	public void onRabitDeath(HeroRabit rabit) {
		//При смерті кролика повертаємо на початкову позицію
		rabit.transform.position = this.startingPosition;
	}
	void Awake() { 
		current = this;
	}


	public void addCoins(int coin){
		this.coins+=coin;	
	}

	public void addFruits(int fruit){
		this.fruits+=fruit;	
	}
		public void addGems(int gem){
		this.gems+=gem;	
	}
}