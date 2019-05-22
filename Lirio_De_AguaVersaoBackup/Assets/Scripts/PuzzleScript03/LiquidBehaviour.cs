using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidBehaviour : MonoBehaviour
{

    public int percent;

    public int liquidLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetPosition();
    }

    private void SetPosition()
    {
        switch (percent)
        {
            case 0:
                transform.localPosition = new Vector3(0, -0.1512f, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(0, -0.12758f, 0);
                break;
            case 2:
                transform.localPosition = new Vector3(0, -0.10396f, 0);
                break;
            case 3:
                transform.localPosition = new Vector3(0, -0.08034f, 0);
                break;
            case 4:
                transform.localPosition = new Vector3(0, -0.05672f, 0);
                break;
            case 5:
                transform.localPosition = new Vector3(0, -0.0331f, 0);
                break;
            case 6:
                transform.localPosition = new Vector3(0, -0.00948f, 0);
                break;
            case 7:
                transform.localPosition = new Vector3(0, 0.01414f, 0);
                break;
            case 8:
                transform.localPosition = new Vector3(0, 0.03776f, 0);
                break;
            case 9:
                transform.localPosition = new Vector3(0, 0.06138f, 0);
                break;
            case 10:
                transform.localPosition = new Vector3(0, 0.085f, 0);
                break;
        }
    }
    
}
