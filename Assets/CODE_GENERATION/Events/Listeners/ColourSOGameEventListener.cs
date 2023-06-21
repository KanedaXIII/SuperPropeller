using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "ColourSO")]
	public sealed class ColourSOGameEventListener : BaseGameEventListener<ColourSO, ColourSOGameEvent, ColourSOUnityEvent>
	{
	}
}