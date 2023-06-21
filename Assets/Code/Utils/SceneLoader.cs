using ScriptableObjectArchitecture;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [Header("Configuration")]
    public SceneSO sceneToLoad;
    public bool loadingScreen;
    public bool resetScene;


    [Header("Broadcasting events")]
    public LoadSceneRequestGameEvent loadSceneEvent;
    

    public void LoadScene()
    {

        var request = new LoadSceneRequest(
            scene: this.sceneToLoad,
            loadingScreen: this.loadingScreen,
            resetScene: this.resetScene
        );

        this.loadSceneEvent.Raise(request);
    }
}
