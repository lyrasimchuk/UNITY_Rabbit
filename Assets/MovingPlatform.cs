using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
	public Vector3 MoveBy;
	Vector3 pointA;
	Vector3 pointB;
	bool going_to_a = false;
	float time_to_wait;
	public float speed = 0.05f;
	public float stoptime = 2.0f;
	bool isArrived(Vector3 pos, Vector3 target) {
		pos.z = 0;
		target.z = 0;
		return Vector3.Distance(pos, target) < 0.02f;
	}
	// Use this for initialization
	void Start () {
		
		this.pointA = this.transform.position;
		this.pointB = this.pointA + MoveBy;
		}
		
	void Update () {
		time_to_wait -= Time.deltaTime;
		if(time_to_wait <= 0) {
			Vector3 my_pos = this.transform.position;
			Vector3 target;

		if(going_to_a) {
			target = this.pointA;
		} else {
			target = this.pointB;
		}
		
			if (isArrived (my_pos, target)) {
				time_to_wait = stoptime;
				going_to_a = !going_to_a;
			} else {
				Vector3 destination = target - my_pos;
				destination.z = 0;
				float move = this.speed + Time.deltaTime;
				float distance = Vector3.Distance(destination, my_pos);

				Vector3 move_vec = destination.normalized * Mathf.Min(move, distance);
				this.transform.position += move_vec;
			}
	}
	}
}
