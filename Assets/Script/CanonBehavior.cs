using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBehavior : MonoBehaviour
{
    public float fireButtonPressedTime = 0.0f;
    public float maxTime = 3.0f;
    public GameObject bulletToSpawn;
    public GameObject bulletSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // As long as fire 1 is pressed it adds to the timer
        if (Input.GetButton("Fire1")){
            fireButtonPressedTime += Time.deltaTime;
        }
        
        if (Input.GetButtonUp("Fire1")){
            //Once you release the fire button you spawn the bullet 
            float ratio = fireButtonPressedTime/ maxTime;
            ratio = Mathf.Clamp(ratio,0,1);
            GameObject bullet = Instantiate(bulletToSpawn, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            //Destroy(bullet, 7.0f);
            BulletComponent bulletComponent = bullet.GetComponent<BulletComponent>();
            if(bulletComponent != null)
            {
                bulletComponent.strengthRatio = ratio;
            }
            fireButtonPressedTime = 0;
        }
    }
}
