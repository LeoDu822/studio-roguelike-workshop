using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float projectileSpeed;
    [SerializeField] float shootingCooldown;

    float lastShotTime = 0;
    // Start is called before the first frame update
    public void Shoot(Vector2 direction)
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        Projectile projectileScript = projectile.GetComponent<Projectile>();
        projectileScript.SourceTag = gameObject.tag;

        projectile.GetComponent<Rigidbody2D>().velocity = new Vector3(direction.x, direction.y, 0) * projectileSpeed;

        lastShotTime = Time.time;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
