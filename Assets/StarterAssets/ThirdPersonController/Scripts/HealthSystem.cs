using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 5;
    [SerializeField]
    int currentHealth = 2;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        UpdateAnimator();
    }
    public bool ModifyHealth(int amount)
    {
        bool isUsed = true; //Para saber si vas a coger o no la vida
        if (currentHealth + amount <= 0)
        {
            currentHealth = 0;
            Debug.Log("Has Muerto");
            isUsed = false; //Lo pones en false para, en el caso de que sea una trampa no se elimine
        }
        else if (currentHealth != maxHealth)//Cuando la vida no sea la maxima se sumara la vida??
        {
            if (currentHealth + amount > maxHealth && amount > 0)
            {
                Debug.Log("Vida al Maximo");
                currentHealth = maxHealth;
            }
            else 
            {
                Debug.Log(amount + " vida");
                currentHealth += amount;
            }
        }
        else if(currentHealth<=maxHealth && amount<0)
        {
            Debug.Log(amount + " vida");
            currentHealth += amount;
        }
        else//Cuando no se coja el PowerUp el valor del bool sera falso y no destruirá el powerUp
        {
            isUsed = false;
        }
        
        UpdateAnimator();
        return isUsed;
    }
    void UpdateAnimator()
    {
        //animator.SetInteger("Health", currentHealth);
    }
}
