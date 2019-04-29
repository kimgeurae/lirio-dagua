using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Canvas c;

    bool a = false;
    float z = 0f;

    public BlinkingTxt b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            z += 1 * Time.deltaTime;
        }
        if (Input.anyKey && z > 2f)
        {
            b.StopBlinking();
            SceneManager.LoadScene(1);
        }
        else if (Input.anyKey)
        {
            c.gameObject.SetActive(true);
            a = true;
        }
    }
}
