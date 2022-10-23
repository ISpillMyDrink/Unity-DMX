using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DMX;

[RequireComponent(typeof(Light))]
public class SyncToLightSource : MonoBehaviour
{
    Light light;
    GameObject dmxObject;
    DMXObject dmx;

    // Start is called before the first frame update
    void Awake()
    {
        light = GetComponent<Light>();

        dmxObject = GameObject.Find("DMXObject");
        dmx = dmxObject.GetComponent<DMX.DMXObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set red value
        dmx[1] = (int)(light.color.r * 255);

        // Set green value
        dmx[2] = (int)(light.color.g * 255);

        // Set blue value
        dmx[3] = (int)(light.color.b * 255);

        // Set intensity value but cap it at a max of 255
        float intensity = light.intensity * 255;
        dmx[4] = (int)(intensity > 255 ? 255 : intensity);
    }
}
