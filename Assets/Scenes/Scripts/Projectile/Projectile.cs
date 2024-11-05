using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //ComponentType myComponent = GetComponent<ComponentType>()
    [SerializeField] float damage = 1f;
    [SerializeField] public string SourceTag;
    
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (!other.gameObject.CompareTag(SourceTag))
        {
            Entity entity = other.GetComponent<Entity>();

            if (entity)
            {
                entity.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
