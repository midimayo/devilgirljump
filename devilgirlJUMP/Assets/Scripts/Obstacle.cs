using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //player takes damage
            other.GetComponent<playerController>().health -= damage;
            //Debug.Log(other.GetComponent<playerController>().health);
            Destroy(gameObject);
        }
        
    }
}
