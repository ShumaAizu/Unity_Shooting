using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public GameObject AttackColl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(1.0f, 0.0f, 0.0f));
    }

    // 当たったら
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
            Debug.Log("test");
        }

        if (other.gameObject.tag == "Object")
        {
            Debug.Log("test");
        }
        Destroy(gameObject);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //当たってきたオブジェクトの名前がプレイヤーの名前と同じとき
    //    if (other.name == player.name)
    //    {
    //        other.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
    //        Debug.Log("test");
    //    }
    //}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("test");
            col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
        }
    }
}
