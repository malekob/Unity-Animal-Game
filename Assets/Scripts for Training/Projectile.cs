using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20;
    private float boundz = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z > boundz)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            PlayerController2 player = GameObject.Find("Player").GetComponent<PlayerController2>();
            if (player != null)
            {
                player.AddScore();
            }
            
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
