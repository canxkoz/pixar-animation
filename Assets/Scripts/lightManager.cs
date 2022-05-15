using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class lightManager : MonoBehaviour
{
    public GameObject directionalLight;
    public GameObject luxoJrSpotOut;
    public GameObject luxoJrSpotIn;
    public GameObject luxoShade;
    private HDAdditionalLightData dlightData;
    private HDAdditionalLightData sOutlightData;
    private HDAdditionalLightData sInlightData;
    private bool dlightsIsOn = true;
    private bool slightsIsOn = true;

    private void Awake()
    {
        dlightData = directionalLight.GetComponent<HDAdditionalLightData>();
        sOutlightData = luxoJrSpotOut.GetComponent<HDAdditionalLightData>();
        sInlightData = luxoJrSpotIn.GetComponent<HDAdditionalLightData>();
    }
    public void dLightSwitch()
    {
        if (dlightsIsOn)
        {
            
            dlightData.intensity = 0;
            dlightsIsOn = false;
        }          
        else
        {
            dlightData.intensity = 130000;
            dlightsIsOn = true;
        }         
    }
    public void sLightSwitch()
    {
        if (slightsIsOn)
        {
            sOutlightData.intensity = 0;
            sInlightData.intensity = 0;
            float emissiveIntensity = 0;
            Color emissiveColor = Color.black;
            luxoShade.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
            slightsIsOn = false;
        }
        else
        {
            sOutlightData.intensity = 27;
            sInlightData.intensity = 27;
            float emissiveIntensity = 50000f;
            Color emissiveColor = Color.white;
            luxoShade.GetComponent<Renderer>().material.SetColor("_EmissiveColor", emissiveColor * emissiveIntensity);
            slightsIsOn = true;
        }
        
    }


}
