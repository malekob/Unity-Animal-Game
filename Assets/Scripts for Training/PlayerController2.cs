using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float horizontalInput;
    private float VerticalInput;
    public float speed = 3;
    private float boundx = 10;
    private float boundzUp = 14;

    public GameObject projectilePrefab;

    private int lives = 3;
    private int score = 0;

    private UiManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

        if (lives <= 0)
        {
            GameOver();
        }
        
    }

    private void Movement()
    {
        if (transform.position.x < -boundx)
        {
            transform.position = new Vector3(-boundx, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > boundx)
        {
            transform.position = new Vector3(boundx, transform.position.y, transform.position.z);

        }
        else if (transform.position.z > boundzUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, boundzUp);
        }
        else if (transform.position.z < -3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 1, 1.5f), projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * VerticalInput * speed * Time.deltaTime);

    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Destroy(gameObject);
    }

    public void Damage()
    {
        lives--;
        uiManager.UpdateLives(lives);
    }

    public void AddScore()
    {
        score += 1;
        uiManager.UpdateScore(score);
    }
}
