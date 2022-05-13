using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shaderChange : MonoBehaviour
{
    public GameObject PixarTextP;
    public GameObject PixarTextI;
    public GameObject PixarTextX;
    public GameObject PixarTextA;
    public GameObject PixarTextR;
    public GameObject sceneBackdrop;
    public Material fresnelShaderMat;
    public Material originShaderMatPixar;
    public Material originShaderMatBackdrop;
    private bool isFresnelPxr = false;
    private bool isFresnelBack = false;
    public Text pxrBtnText;
    public Text backBtnText;
    public void shaderChangePixar()
    {
        if (!isFresnelPxr)
        {
            isFresnelPxr = true;
            pxrBtnText.text = "Material Fresnel Shader";
            PixarTextP.GetComponent<Renderer>().material = fresnelShaderMat;
            PixarTextI.GetComponent<Renderer>().material = fresnelShaderMat;
            PixarTextX.GetComponent<Renderer>().material = fresnelShaderMat;
            PixarTextA.GetComponent<Renderer>().material = fresnelShaderMat;
            PixarTextR.GetComponent<Renderer>().material = fresnelShaderMat;
        }
        else
        {
            isFresnelPxr = false;
            pxrBtnText.text = "Material Origin PBR";
            PixarTextP.GetComponent<Renderer>().material = originShaderMatPixar;
            PixarTextI.GetComponent<Renderer>().material = originShaderMatPixar;
            PixarTextX.GetComponent<Renderer>().material = originShaderMatPixar;
            PixarTextA.GetComponent<Renderer>().material = originShaderMatPixar;
            PixarTextR.GetComponent<Renderer>().material = originShaderMatPixar;
        }

            
    }
    public void shaderChangeBackdrop()
    {
        if (!isFresnelBack)
        {
            isFresnelBack = true;
            backBtnText.text = "Material Fresnel Shader";
            sceneBackdrop.GetComponent<Renderer>().material = fresnelShaderMat;
        }
        else
        {
            isFresnelBack = false;
            backBtnText.text = "Material Origin PBR";
            sceneBackdrop.GetComponent<Renderer>().material = originShaderMatBackdrop;
        }


    }
}
