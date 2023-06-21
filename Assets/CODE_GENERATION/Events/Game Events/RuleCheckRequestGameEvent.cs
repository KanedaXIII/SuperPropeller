using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "RuleCheckRequestGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "RuleCheckRequest",
	    order = 120)]
	public sealed class RuleCheckRequestGameEvent : GameEventBase<RuleCheckRequest>
	{
	}
}