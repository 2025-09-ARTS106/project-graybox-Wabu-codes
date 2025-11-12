using UnityEngine;

public class SkyBoxChange : MonoBehaviour
{
//create editors in inspector menu?
    public Material Day;
    public Material Sunset;
    public Material Night;
    // Start called before first frame update

    void Start()
    {
        Invoke("ChangeSkyBox3", 3); //sunset
        Invoke("ChangeSkyBox",6); //turn to night (in seconds)
        Invoke("ChangeSkyBox2", 12); //turn to day
    }

    //Change to night
    void ChangeSkyBox()
    {
        RenderSettings.skybox = Night;
    }
    //Change to day
    void ChangeSkyBox2()
    {
        RenderSettings.skybox = Day;
    }
    //change to sunset
    void ChangeSkyBox3()
    {
        RenderSettings.skybox = Sunset;
    }
}