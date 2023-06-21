using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "RuleCheckRequest")]
	public sealed class RuleCheckRequestGameEventListener : BaseGameEventListener<RuleCheckRequest, RuleCheckRequestGameEvent, RuleCheckRequestUnityEvent>
	{
	}
}