using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBounce : MonoBehaviour
{
    Light light;

    // Start is called before the first frame update
    void Awake()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        light.color = new Color(Mathf.PingPong(Time.time, 1), 0, 0);
    }
}
