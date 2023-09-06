using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    Rigidbody rb;
    public float strength;
    public float strengthRatio = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * strength * strengthRatio, ForceMode.Impulse);
        Destroy(gameObject, 5.0f);
        //Invoke("DestroyBullet",7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DestroyBullet() {
        Destroy(gameObject, 5.0f);
    }
}
