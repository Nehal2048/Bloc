using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public static int score;

    void Start()
    {
        score = -1;
    }
    // Update is called once per frame
    void Update()
    {
        // score = player.position.y;

        scoreText.text = score.ToString();

    }
}
