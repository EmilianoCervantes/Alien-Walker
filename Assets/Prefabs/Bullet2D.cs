using UnityEngine;
using System.Collections;

public class Bullet2D : MonoBehaviour {

	public int Direction = 1;
	public float Speed = .1f;

	// Update is called once per frame
	void Update () {
		Vector3 p = transform.position;
		p.x += Direction * Speed;
		transform.position = p;
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}