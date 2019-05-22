using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidControl : MonoBehaviour
{

    public GameObject leftSlot;
    public GameObject middleSlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransferLiquid()
    {
        LiquidBehaviour _leftLiquidBehaviour = leftSlot.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<LiquidBehaviour>();
        LiquidBehaviour _middleLiquidBehaviour = middleSlot.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<LiquidBehaviour>();
        while (_leftLiquidBehaviour.percent < _leftLiquidBehaviour.liquidLimit && _middleLiquidBehaviour.percent > 0)
        {
            _leftLiquidBehaviour.percent++;
            _middleLiquidBehaviour.percent--;
        }
    }

}
