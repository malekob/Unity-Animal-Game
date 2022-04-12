using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            PlayerController2 player = other.GetComponent<PlayerController2>();
            if (player != null)
            {
                player.Damage();
            }
            
            Destroy(this.gameObject);
        }
        else if (other.tag == "Animal")
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);

            Destroy(gameObject);
        }
    }
}
