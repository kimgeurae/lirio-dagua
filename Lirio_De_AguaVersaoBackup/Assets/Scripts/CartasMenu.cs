using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartasMenu : MonoBehaviour
{

    public GameObject[] _letter;
    bool showMenu = false;
    int letterIndex = 0;
    bool displayMenu = false;
    public GameObject _warning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            displayMenu = !displayMenu;
            DisplayCards();
            _warning.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (letterIndex < _letter.Length - 1)
            {
                letterIndex++;
                DisplayCards();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (letterIndex > 0)
            {
                letterIndex--;
                DisplayCards();
            }
        }
    }

    private void DisplayCards()
    {
        if (displayMenu)
        {
            for (int i = 0; i < _letter.Length; i++)
            {
                _letter[i].gameObject.SetActive(false);
            }
            _letter[letterIndex].gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < _letter.Length; i++)
            {
                _letter[i].gameObject.SetActive(false);
            }
        }
    }

}
