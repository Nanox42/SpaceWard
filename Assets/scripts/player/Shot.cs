using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    public float shotForce = 500;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newbullet;
                newbullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newbullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                shotRateTime = Time.time + shotRate;
                Destroy(newbullet, 3);
                Debug.Log("dispare una bala");
            }
        }
    }
}
