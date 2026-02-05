using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "player")
		{
			col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
			GetComponent<ParticleSystem>().Play();
		}
	}
}
