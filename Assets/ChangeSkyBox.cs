using System.Collections;
using UnityEngine;

public class SkyBoxChange : MonoBehaviour
{
    //create editors in inspector menu?
    public Material Day;
    public Material Sunset;
    public Material Night;
    public bool dayNightIsRunning;
    public float DayLength = 12f;
    public float FirstDayLength = 3f;
    public float SunsetLength = 3f;
    public float NightLength = 6f;

    // Start called before first frame update

    void Start()
    {
        dayNightIsRunning = true;
        StartCoroutine(ChangeSkyboxCoRoutine());
        //Invoke("ChangeSkyBox3", 3); //sunset
        //Invoke("ChangeSkyBox", 6); //turn to night (in seconds)
        //Invoke("ChangeSkyBox2", 12); //turn to day
    }


    IEnumerator ChangeSkyboxCoRoutine()
    {
        yield return new WaitForSeconds(FirstDayLength); //day
        ChangeSkyBoxSunset();
        yield return new WaitForSeconds(3f); //duration of sunset
        ChangeSkyBoxNight();
        yield return new WaitForSeconds(6f); //duration of night

        while (dayNightIsRunning)
        {

            ChangeSkyBoxDay();
            yield return new WaitForSeconds(DayLength);

            ChangeSkyBoxSunset();
            yield return new WaitForSeconds(SunsetLength);

            ChangeSkyBoxNight();
            yield return new WaitForSeconds(NightLength);

        }

        ChangeSkyBoxDay();

    }


    //Change to night
    void ChangeSkyBoxNight()
    {
        RenderSettings.skybox = Night;
    }
    //Change to day
    void ChangeSkyBoxDay()
    {
        RenderSettings.skybox = Day;
    }
    //change to sunset
    void ChangeSkyBoxSunset()
    {
        RenderSettings.skybox = Sunset;
    }
}