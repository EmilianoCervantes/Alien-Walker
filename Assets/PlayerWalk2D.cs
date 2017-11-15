using UnityEngine;
using System.Collections;

public class PlayerWalk2D : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Velocidad del personaje
	public float Speed = 0.1f;
	public int _lastOrientation = 1;
	void Update () {
		// Obtenemos el valor del eje horizontal y de la velocidad
		float h = Input.GetAxis("Horizontal") * Speed;
		// Obtenemos la posición del objeto al cual pertenece este componente
		Vector3 position = gameObject.transform.position;
		// Modificamos la posición en x a partir del valor horizontal y su velocidad
		position.x += h;
		// Asignamos la nueva posición al objeto
		gameObject.transform.position = position;
	}
}