using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun1 : MonoBehaviour
{

    public Transform bulletSpawnPoint;

    public GameObject bulletPrefab;

    public float bulletspeed = 10;



    // Start is called before the first frame update

   

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyUp(KeyCode.Space))
            {

                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
            }
       
    }
}
