using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    #region Fields

    public float frequency; // How often a bullet spawns
    public Direction direction; // Which direction the bullet goes in

    [SerializeField]
    private GameObject bulletPrefab;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
