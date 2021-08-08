using UnityEngine;

public class GameManager: SingletonMonoBehaviour<GameManager>
{
    public Weather currentWeather;
    protected override void Awake()
    {
        base.Awake();

        // TODO: need a resolution settings options screen
        Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow, 0);

        // set starting weather
        currentWeather = Weather.dry;
    }
}