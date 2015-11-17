using UnityEngine;
using System.Collections;

public class FasterCharacter : CharacterBase //the script's name writing under it.
{

	private Material mat;

	public override void Start (Collision other)
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.mass = 20;
		speed = 35f;
		health = 10f;
	}
	
	public void takeDamage (float damage)
	{
	}
}
