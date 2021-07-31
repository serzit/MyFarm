using UnityEngine;

public class GameManager: SingletonMonoBehaviour<GameManager>
{
    protected override void Awake()
    {
        base.Awake();

        // TODO: need a resolution settings options screen
        Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow, 0);
    }
}