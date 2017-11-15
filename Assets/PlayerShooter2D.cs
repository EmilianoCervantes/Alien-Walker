using UnityEngine;
using System.Collections;

public class PlayerShooter2D : MonoBehaviour {

	public GameObject BulletPrefab;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown("Fire1")) {
			GameObject bullet = Instantiate(BulletPrefab) as GameObject;
			bullet.transform.position = gameObject.transform.position;
			if(){
				int direction = 1;
			}else{
				int direction =-1;
			}
			if (transform.localScale.x < 0) {
				direction = -1;
			}
			bullet.GetComponent<Bullet2D>().Direction = direction;
		}
	}
}