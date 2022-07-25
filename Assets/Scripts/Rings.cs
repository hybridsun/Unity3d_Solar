using UnityEngine;
using System.Collections;

public class Rings : MonoBehaviour 
{
	/// <summary>
	/// The "planet" object that this "rings" object is associated with.
	/// </summary>
	public GameObject planet;

	void LateUpdate () 
	{
		transform.position = planet.transform.position;
	}
}
