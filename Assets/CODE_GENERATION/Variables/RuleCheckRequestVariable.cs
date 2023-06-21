using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class RuleCheckRequestEvent : UnityEvent<RuleCheckRequest> { }

	[CreateAssetMenu(
	    fileName = "RuleCheckRequestVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "RuleCheckRequest",
	    order = 120)]
	public class RuleCheckRequestVariable : BaseVariable<RuleCheckRequest, RuleCheckRequestEvent>
	{
	}
}