using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceBehaviour : MonoBehaviour
{

    public enum State {left, up, right, down, };
    public State state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DefineRotation();
    }

    private void DefineRotation()
    {
        switch (state)
        {
            case State.up:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case State.right:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case State.down:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case State.left:
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
        }
    }

}
