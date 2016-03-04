using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public LayerMask collisionMask;
	float speed = 10;
	float damage = 1;
	private float dTravel=0;

	public void SetSpeed(float newSpeed){
		speed = newSpeed;
	}

	// Update is called once per frame
	void Update () {
		//bullet needs to destory itself if it travels too far.
		dTravel += 1f;
		if (dTravel > 11) {
			Destroy (this.gameObject);
		}

		float moveDistance = speed * Time.deltaTime;
		CheckCollisions (moveDistance);
		transform.Translate (-Vector3.down * moveDistance);
	}

	void CheckCollisions(float moveDistance){
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		/*
		if (Physics.Raycast (ray, out hit, moveDistance, collisionMask, QueryTriggerInteraction.Collide)) {
			OnHitObject(hit);
			}
			*/
	}

	/*
	void OnHitObject(RaycastHit hit){
		IDamageable damageableObject = hit.collider.GetComponent<IDamageable> ();
		if (damageableObject != null) {
			damageableObject.TakeHit(damage, hit);
		}
		GameObject.Destroy (gameObject);
	} */
}