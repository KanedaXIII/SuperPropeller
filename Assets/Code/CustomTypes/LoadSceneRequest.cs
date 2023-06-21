[System.Serializable]
public class LoadSceneRequest
{
    public SceneSO scene;
    public bool loadingScreen;
    public bool resetScene;

    public LoadSceneRequest(SceneSO scene, bool loadingScreen, bool resetScene)
    {
        this.scene = scene;
        this.loadingScreen = loadingScreen;
        this.resetScene = resetScene;
    }
}
