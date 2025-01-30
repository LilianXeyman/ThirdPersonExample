using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GenericPool bulletPool;
    float timer = 5f;
    public float speed=1.5f;

    float meters = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.position*Time.deltaTime*speed;
        //meters += (transform.position * Time.deltaTime * speed).magnitude;//limite en metros 
        timer -=Time.deltaTime;
        if (timer < 0)//También se puede poner el límite con metros 
        {
            timer = 5f;
            bulletPool.ReturnToPool(gameObject);
        }
    }
}
