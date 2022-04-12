using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lives_Text;

    // Start is called before the first frame update
    void Start()
    {
        lives_Text.text = "Lives: " + 3;
        scoreText.text = "Score: " + 0;
    }

    // Update is called once per frame
    public void UpdateLives(int currentlives)
    {
        lives_Text.text = "Lives: " + currentlives;
    }

    public void UpdateScore(int currScore)
    {
        scoreText.text = "Score: " + currScore;
    }
}
