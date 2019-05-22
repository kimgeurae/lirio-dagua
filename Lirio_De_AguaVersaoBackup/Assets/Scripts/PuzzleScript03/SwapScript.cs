using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapScript : MonoBehaviour
{

    public GameObject[] _slots;
    public GameObject[] _thermometers;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _thermometers.Length; i++)
        {
            _thermometers[i].transform.SetParent(_slots[i].transform);
        }
        DefinePosition();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Swap01();
            DefinePosition();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Swap02();
            DefinePosition();
        }
        */
    }

    private void DefinePosition()
    {
        for (int i = 0; i < _thermometers.Length; i++)
        {
            _thermometers[i].transform.localPosition = Vector3.zero;
        }
    }

    public void Swap01()
    {
        Debug.Log("Rodou Swap01");
        for (int i = 0; i < _thermometers.Length; i++)
        {
            switch (_thermometers[i].transform.parent.gameObject.tag)
            {
                case "leftSlot":
                    _thermometers[i].transform.SetParent(_slots[1].transform);
                    break;
                case "middleSlot":
                    _thermometers[i].transform.SetParent(_slots[0].transform);
                    break;
                case "rightSlot":
                    // Do nothing.
                    break;
            }
        }
        DefinePosition();
    }

    public void Swap02()
    {
        Debug.Log("Rodou Swap02");
        for (int i = 0; i < _thermometers.Length; i++)
        {
            switch (_thermometers[i].transform.parent.gameObject.tag)
            {
                case "leftSlot":
                    // Do nothing.
                    break;
                case "middleSlot":
                    _thermometers[i].transform.SetParent(_slots[2].transform);
                    break;
                case "rightSlot":
                    _thermometers[i].transform.SetParent(_slots[1].transform);
                    break;
            }
        }
        DefinePosition();
    }

}