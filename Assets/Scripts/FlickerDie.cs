using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Light))]

public static class ExtensionMethods
{

    public static float Remap(this float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

}


public class flickerDie : MonoBehaviour
{

    public float minIntensity = 0f;
    public float maxIntensity = 4.5f;
    Light BallLight;
    float random;
    bool start = true;
    Material parentMaterial;
    Color parentMaterialColor;
    Color temp;
    private float currentTime = 0f;
    private float fadeTime = 1.5f;

    void Start()
    {
        parentMaterial = GetComponentInParent<MeshRenderer>().material;
        parentMaterialColor = parentMaterial.GetColor("_EmissionColor");

        BallLight = GetComponent<Light>();

        StartCoroutine(Iflicker());
    }

    IEnumerator Iflicker()
    {
        yield return new WaitForSeconds(1.5f);
        start = false;
    }

    void Update()
    {

        if (start == true)
        {
            currentTime += Time.deltaTime;
            BallLight.intensity = UnityEngine.Random.Range(minIntensity, (Mathf.Lerp(maxIntensity, 0f, currentTime / fadeTime))).Remap(0f,4.5f,0f,1f);
            parentMaterial.SetColor("_EmissionColor", parentMaterialColor * BallLight.intensity);
        }
        if (start == false)
        {
            BallLight.intensity = 0;
            Destroy(GetComponent<flickerDie>());
        }
    }


}


