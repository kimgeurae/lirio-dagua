using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{

    public GameObject[] _pieces;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate(int i)
    {
        PieceBehaviour _pieceBehaviour = _pieces[i].GetComponent<PieceBehaviour>();
        switch (_pieceBehaviour.state)
        {
            case PieceBehaviour.State.up:
                _pieceBehaviour.state = PieceBehaviour.State.right;
                break;
            case PieceBehaviour.State.right:
                _pieceBehaviour.state = PieceBehaviour.State.down;
                break;
            case PieceBehaviour.State.down:
                _pieceBehaviour.state = PieceBehaviour.State.left;
                break;
            case PieceBehaviour.State.left:
                _pieceBehaviour.state = PieceBehaviour.State.up;
                break;
        }
    }

}
