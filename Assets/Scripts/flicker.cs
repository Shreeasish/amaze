using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Light))]
public class flicker : MonoBehaviour {
   
        public float minIntensity = 0f;
        public float maxIntensity = 2f;
        Light  BallLight;
        float random;
        bool start = true;
        Material parentMaterial;
    Color parentMaterialColor;
    Color temp;



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
            BallLight.intensity = UnityEngine.Random.Range(minIntensity, maxIntensity);
            parentMaterial.SetColor("_EmissionColor", parentMaterialColor * Mathf.Clamp01(BallLight.intensity));
            

        }
        if (start == false)
        {
            BallLight.intensity = 4.5f;
            parentMaterial.SetColor("_EmissionColor", parentMaterialColor);
            Destroy(GetComponent<flicker>());
        }
    }
}

