using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle02VitoryCondition : MonoBehaviour
{

    public CompressorBehaviour[] _compressorBehaviour;
    public Light _winningLight;

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
        if (_compressorBehaviour[0].state == CompressorBehaviour.State.y7 && _compressorBehaviour[1].state == CompressorBehaviour.State.y6 && _compressorBehaviour[2].state == CompressorBehaviour.State.y4)
        {
            _winningLight.color = Color.green;
        }
        else
        {
            _winningLight.color = Color.red;
        }
    }

}
