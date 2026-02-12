using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGenerator : MonoBehaviour
{
    public GameObject AttackPrefab;     // UŒ‚”»’èƒvƒŒƒnƒu

    private static int nCntCool = 0;

    public BossController BossController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossController.GetEndBoss() == false)
        {
            if (nCntCool < 0)
            {
                nCntCool = Random.Range(60, 180);
            }

            nCntCool--;

            if (nCntCool < 0)
            {
                int nPattern = Random.Range(1, 4);
                Vector3 vector = this.transform.position;

                switch (nPattern)
                {
                    case 1:
                        vector.z += -100.0f;
                        break;

                    case 2:

                        break;

                    case 3:
                        vector.z += 100.0f;
                        break;
                }

                Instantiate(AttackPrefab, vector, Quaternion.identity);
            }
        }
    }
}
