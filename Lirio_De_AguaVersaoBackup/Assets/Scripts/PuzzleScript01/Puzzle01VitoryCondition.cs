using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle01VitoryCondition : MonoBehaviour
{

    public PieceBehaviour[] _pieces;
    public Light[] _feedbackLights;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WinningCondition();
    }

    private void WinningCondition()
    {
        if (_pieces[0].state == PieceBehaviour.State.up && _pieces[1].state == PieceBehaviour.State.up && _pieces[2].state == PieceBehaviour.State.up && _pieces[3].state == PieceBehaviour.State.up && _pieces[4].state == PieceBehaviour.State.up
            && _pieces[5].state == PieceBehaviour.State.up && _pieces[6].state == PieceBehaviour.State.up && _pieces[7].state == PieceBehaviour.State.up && _pieces[8].state == PieceBehaviour.State.up)
        {
            if (_feedbackLights[0].color != Color.green)
            {
                for (int i = 0; i < _feedbackLights.Length; i++)
                {
                    _feedbackLights[i].color = Color.green;
                }
            }
        }
        else
        {
            if (_feedbackLights[0].color != Color.red)
            {
                for (int i = 0; i < _feedbackLights.Length; i++)
                {
                    _feedbackLights[i].color = Color.red;
                }
            }
        }
    }

}
