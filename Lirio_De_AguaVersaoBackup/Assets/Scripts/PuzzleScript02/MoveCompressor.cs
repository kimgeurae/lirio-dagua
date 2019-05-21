using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCompressor : MonoBehaviour
{

    public CompressorBehaviour[] _compressorBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCompressorUpMethod(int i)
    {
        switch (i)
        {
            case 0:
                switch (_compressorBehaviour[0].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            case 1:
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[0].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[2].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            case 2:
                switch (_compressorBehaviour[2].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            default:
                Debug.Log("Error puzzle 02, Move Compressor Script");
                break;
        }
    }

    public void MoveCompressorDownMethod(int i)
    {
        switch (i)
        {
            case 0:
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[0].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            case 1:
                switch (_compressorBehaviour[0].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[0].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[2].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            case 2:
                switch (_compressorBehaviour[1].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y9;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[1].state = CompressorBehaviour.State.y10;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                switch (_compressorBehaviour[2].state)
                {
                    case CompressorBehaviour.State.y0:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y1:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y0;
                        break;
                    case CompressorBehaviour.State.y2:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y1;
                        break;
                    case CompressorBehaviour.State.y3:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y2;
                        break;
                    case CompressorBehaviour.State.y4:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y3;
                        break;
                    case CompressorBehaviour.State.y5:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y4;
                        break;
                    case CompressorBehaviour.State.y6:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y5;
                        break;
                    case CompressorBehaviour.State.y7:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y6;
                        break;
                    case CompressorBehaviour.State.y8:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y7;
                        break;
                    case CompressorBehaviour.State.y9:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y8;
                        break;
                    case CompressorBehaviour.State.y10:
                        _compressorBehaviour[2].state = CompressorBehaviour.State.y9;
                        break;
                    default:
                        Debug.Log("Error puzzle 02, Move Compressor Script");
                        break;
                }
                break;
            default:
                Debug.Log("Error puzzle 02, Move Compressor Script");
                break;
        }
    }

}
