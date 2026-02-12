using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //public void Shoot(Vector3 dir)
    //{
    //    GetComponent<Rigidbody>().AddForce(dir);
    //}

    public int nBLife = 10;  // éıñΩ

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<ParticleSystem>().Play();
        // PlayerÇ≈Ç†ÇÍÇŒé©ï™é©êgÇ2ïbå„Ç…çÌèú
        Destroy(this.gameObject, 1f);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        nBLife--;
        if (nBLife < 0)
        {
            Destroy(this.gameObject, 1f);
        }
    }
}
