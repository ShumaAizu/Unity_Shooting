using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    private bool isEndBoss = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "EndObject")
        {
            isEndBoss = true;
        }
    }

    public bool GetEndBoss()
    {
        return isEndBoss;
    }
}
