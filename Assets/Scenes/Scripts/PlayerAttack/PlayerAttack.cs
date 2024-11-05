using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick(InputValue value)
    {
        if (value.isPressed)
        {
            Vector3 mouseScreenPos = mouseScreenPos.current.position.ReadValue();
            Vector3 mouseWorldPos = camera.ScreenToWorldPoint(mouseScreenPos + new Vector3(0, 0, camera.nearClipPlane));

            Vector2 dir = new Vector2(mouseWorldPos.x - transform.position.x, mouseWorldPos.y - transform.position.y);
            dir.Normalize();
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
