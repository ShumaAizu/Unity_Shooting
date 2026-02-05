using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(0.0f, 0.0f, 5.0f));

        
    }

    // “–‚½‚Á‚½‚ç
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
        }

        if(other.gameObject.tag == "Object")
        {

        }
    }
}
