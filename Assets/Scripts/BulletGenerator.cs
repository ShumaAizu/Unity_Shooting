using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    GameObject bullet = Instantiate(BulletPrefab);
        //
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Vector3 worldDir = ray.direction;
        //    bullet.GetComponent<BulletController>().Shoot(worldDir.normalized * 2000);
        //}

        // ESCÉLÅ[Ç≈èIóπ
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
