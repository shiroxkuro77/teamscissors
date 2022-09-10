using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    #region Fields

    public float frequency = 2f; // How often a bullet spawns
    public Direction direction; // Which direction the bullet goes in

    [SerializeField]
    private GameObject bulletPrefab;
    private Vector3 bulletPosition;
    private GameObject bullet;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        bulletPosition = transform.position;
        InvokeRepeating("SpawnBullet", 0, frequency);
    }

    private void SpawnBullet()
    {
        bullet = Instantiate<GameObject>(bulletPrefab, bulletPosition, transform.rotation);
        bullet.GetComponent<BulletController>().direction = direction;
    }
}
