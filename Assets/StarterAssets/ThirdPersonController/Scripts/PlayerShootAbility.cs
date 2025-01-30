using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShootAbility : MonoBehaviour
{
    private StarterAssetsInputs _input;
    public GenericPool bulletsPool;
    // Start is called before the first frame update
    void Awake()
    {
        _input = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckShoot();
    }
    void CheckShoot()
    {
        if (_input.shoot)
        {
            Debug.Log("Dispara");
            GameObject bullet = bulletsPool.GetElementFromPool();
            bullet.transform.position = transform.position + transform.up*0.5f + transform.forward*0.5f;//Respecto a la posicion local
            bullet.SetActive(true);
            //Release del botón
            _input.shoot = false;
        }
    }
}
