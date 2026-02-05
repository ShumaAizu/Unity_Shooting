using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
        }
	}
}
