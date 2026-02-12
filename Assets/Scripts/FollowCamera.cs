using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;   // 玉のオブジェクト
    private Vector3 offset;     // 玉からカメラまでの距離

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void LateUpdate()   // Updateの後に処理が実行される
    {
        transform.position = player.transform.position + offset;
    }
}
