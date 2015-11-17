using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour
{

	public float speed;
	public float health;

	public void Start ()
	{
		health = 100f;
		speed = 10f;
	}
	
	public void Update ()
	{
		float horz = Input.GetAxis ("Horizontal") * speed;
		float vert = Input.GetAxis ("Vertical") * speed;
	}

	public void takeDamage ()
	{

	}
}
