using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Code;

public class GameplayUI : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField]private GameObject GameOverMenu;

    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private TextMeshProUGUI _lifeText;

    public void SetScore(string score)
    {
        _scoreText.text = score;
    }

    public void SetLife(string life)
    {
        _lifeText.text = life;
    }

    public void SetupHUD(Propeller propeller)
    {
        
    }
}
