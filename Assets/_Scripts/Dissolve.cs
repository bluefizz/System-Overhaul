using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Renderer rend;
    private float ThresholdValue;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        ThresholdValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ThresholdValue <=1)
        {
            ThresholdValue += Time.deltaTime / 10;
            rend.material.SetFloat("_DissolveThreshold", ThresholdValue);
        }
    }
}
