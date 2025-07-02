using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class GameManager : MonoBehaviour
{
    public Text JstoUnity;
    public Text JstoUnityParam;

    [DllImport("__Internal")]
    private static extern void SceneLoaded(string str);

    public void Start()
    {
        SceneLoaded("true");
    }
    public void SetValFromJS()
    {
        JstoUnity.text = "Value Changed by JS";
    }

    public void SetValFromJSParam(string param)
    {
        JstoUnityParam.text = param.ToString();
    }
}
