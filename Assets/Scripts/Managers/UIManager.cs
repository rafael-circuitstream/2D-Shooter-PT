using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI scoreText;

    private Player localPlayer;
    private GameManager localGameManager;

    void Start()
    {
        localPlayer = FindAnyObjectByType<Player>();
        localGameManager = FindAnyObjectByType<GameManager>();

    }

    void Update()
    {
        healthText.text = "HEALTH: " + localPlayer.health.GetCurrentHealth().ToString("F0") + "%";
        scoreText.text = localGameManager.GetCurrentScore().ToString();

        healthText.color = Color.Lerp(Color.red, Color.green, localPlayer.health.GetCurrentHealth() / 100f);
    }
}
