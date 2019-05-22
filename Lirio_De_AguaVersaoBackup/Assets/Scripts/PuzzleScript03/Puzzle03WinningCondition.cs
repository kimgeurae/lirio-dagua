using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle03WinningCondition : MonoBehaviour
{

    public Light _feedbackLight;
    public GameObject _leftSlot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckWinningCondition();
    }

    private void CheckWinningCondition()
    {
        if (_leftSlot.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<LiquidBehaviour>().percent == 6)
        {
            _feedbackLight.color = Color.green;
        }
        else
        {
            _feedbackLight.color = Color.red;
        }
    }

}
