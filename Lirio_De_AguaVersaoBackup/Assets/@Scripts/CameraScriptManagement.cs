using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptManagement : MonoBehaviour
{

    //public FogEffectFX fogFX;
    //public UnderwaterEffect underwaterFX;
    FogEffectFX fogFX;
    UnderwaterEffect underwaterFX;

    private void Awake()
    {
        fogFX = GetComponent<FogEffectFX>();
        underwaterFX = GetComponent<UnderwaterEffect>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.1f)
        {
            //fogFX.enabled = true;
            underwaterFX.enabled = true;
        }
        else {
            //fogFX.enabled = false;
            underwaterFX.enabled = false;
        }
    }
}
