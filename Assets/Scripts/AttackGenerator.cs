using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGenerator : MonoBehaviour
{
    public GameObject AttackPrefab;     // UŒ‚”»’èƒvƒŒƒnƒu

    private static int nCntCool = 0;
    private static int nSetPattern = 0;
    private static bool isSet = false;

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
                nCntCool = Random.Range(90, 240);
            }

            nCntCool--;

            if (nCntCool < 0)
            {
                int nPattern = 0;

                Vector3 vector = this.transform.position;
                while(true)
                {
                  nPattern = Random.Range(1, 4);
                    if(nPattern != nSetPattern)
                    {
                        break;
                    }
                }

                switch (nPattern)
                {
                    case 1:
                        vector.z += -100.0f;
                        nSetPattern = 1;
                        break;

                    case 2:
                        nSetPattern = 2;
                        break;

                    case 3:
                        vector.z += 100.0f;
                        nSetPattern = 3;
                        break;
                }

                Instantiate(AttackPrefab, vector, Quaternion.identity);
            }
        }
    }
}
