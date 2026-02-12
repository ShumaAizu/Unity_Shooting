using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    private static bool isEndBoss = false;
    public GameObject text;         //テキストを格納するための変数

    private static int nCntCollisionBoss = 0;

    // Start is called before the first frame update
    void Start()
    {
        nCntCollisionBoss = 0;
        isEndBoss = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "EndObject")
        {
            nCntCollisionBoss++;

            Destroy(other.gameObject);
            Debug.Log("BossEnd");

            if (nCntCollisionBoss >= 2)
            {
                isEndBoss = true;
            }

            //text.GetComponent<Text>().text = "YOU WON!!";
            //text.SetActive(true);            //テキストをオンにして非表示→表示にする
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "EndObject")
        {
            nCntCollisionBoss++;

            Destroy(col.gameObject);
            Debug.Log("BossEnd");

            if (nCntCollisionBoss >= 2)
            {
                Debug.Log("BossEndtrue");

                Destroy(this.gameObject);

                isEndBoss = true;
            }

            //text.GetComponent<Text>().text = "YOU WON!!";
            //text.SetActive(true);            //テキストをオンにして非表示→表示にする
        }
    }

    public bool GetEndBoss()
    {
        return isEndBoss;
    }
}
