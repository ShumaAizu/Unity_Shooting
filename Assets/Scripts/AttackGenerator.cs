using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGenerator : MonoBehaviour
{
    public GameObject AttackPrefab;     // çUåÇîªíËÉvÉåÉnÉu

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            int nPattern = Random.Range(1, 4);
            Vector3 vector = this.transform.position;

            switch (nPattern)
            {
                case 1:
                    vector.x += -3;
                    break;

                case 2:
                    
                    break;

                case 3:
                    vector.x += 3;
                    break;
            }

            Instantiate(AttackPrefab, vector, Quaternion.identity);
        }
    }
}
