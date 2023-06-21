using Code.GameModes;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] private int _initialLife;

    private int _score;

    //Incluir el IRules para las reclas genericas

    private IRule _regularRules;
    private IRule _currentRules;

    private GameObject MainCameraPro;

    [Header("Dependencies")]
    [SerializeField]private GameplayUI _gameplayUI;

    private void Awake()
    {
        _regularRules = new RegularRules();
        _currentRules = _regularRules;
        
    }

    private void Start()
    {
        MainCameraPro = GameObject.Find("MainCameraPro");
    }

    public int Score 
    { 
        get { return _score; } 
    }

    public void IncreaseScore(RuleCheckRequest ruleCheckRequest)
    {
        if (_currentRules.CheckMatchRule(ruleCheckRequest.bladeColour, ruleCheckRequest.geometricObject))
        {
            _score += 20;
            _gameplayUI.SetScore(_score.ToString());
        }
        else
        {
            var doDamageComponent = ruleCheckRequest.propeller.GetComponent<IDoDamage>();
            if(doDamageComponent != null)
            {
                doDamageComponent.Damage(1);
                var currentH = doDamageComponent.CurrentHealth();
                _gameplayUI.SetLife(currentH.ToString());
            }
            MainCameraPro.GetComponent<ProCamera2DShake>().Shake("SmallExplosion");
        }
    }

    public void Reset()
    {
        _score = 0;
        _gameplayUI.SetLife(_initialLife.ToString());
        _gameplayUI.SetScore(_score.ToString());
        _currentRules = _regularRules;
        MainCameraPro = GameObject.Find("MainCameraPro");
    }

}
