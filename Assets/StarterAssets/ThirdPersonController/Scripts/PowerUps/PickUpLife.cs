using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpLife : MonoBehaviour, IPowerUp
{
    [SerializeField]
    int healthAmount = 1;
    public void PickUpPowerUp(GameObject other)
    {
        if (other.TryGetComponent<HealthSystem>(out HealthSystem health))
        {
            if (health.ModifyHealth(healthAmount))
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}
