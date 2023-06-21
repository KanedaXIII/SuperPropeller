using UnityEngine;

public class RuleManager : MonoBehaviour
{
    [SerializeField] private IRule _defaultRule;

    private IRule _ruleCurrent;

    private void Awake() {
        _ruleCurrent = _defaultRule;
    }

    public void Reset()
    {
            
    }
}
