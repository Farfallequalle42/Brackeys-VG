using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public float compensation = 45;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + compensation).ToString("0");
    }
}
