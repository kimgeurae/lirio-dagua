using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompressorBehaviour : MonoBehaviour
{

    public enum State {y0, y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, };
    public State state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DefinePosition();
    }

    private void DefinePosition()
    {
        switch (state)
        {
            case State.y0:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.0388f, transform.localPosition.z);
                break;
            case State.y1:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.19459f, transform.localPosition.z);
                break;
            case State.y2:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.35038f, transform.localPosition.z);
                break;
            case State.y3:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.50617f, transform.localPosition.z);
                break;
            case State.y4:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.66196f, transform.localPosition.z);
                break;
            case State.y5:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.81775f, transform.localPosition.z);
                break;
            case State.y6:
                transform.localPosition = new Vector3(transform.localPosition.x, 0.97354f, transform.localPosition.z);
                break;
            case State.y7:
                transform.localPosition = new Vector3(transform.localPosition.x, 1.12933f, transform.localPosition.z);
                break;
            case State.y8:
                transform.localPosition = new Vector3(transform.localPosition.x, 1.28512f, transform.localPosition.z);
                break;
            case State.y9:
                transform.localPosition = new Vector3(transform.localPosition.x, 1.44091f, transform.localPosition.z);
                break;
            case State.y10:
                transform.localPosition = new Vector3(transform.localPosition.x, 1.5967f, transform.localPosition.z);
                break;
        }
    }

}
