using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingTxt : MonoBehaviour
{

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartBlinking();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Blink()
    {
        while (true)
        {
            switch (sr.material.color.a.ToString())
            {
                case "0":
                    sr.material.color = new Color(sr.material.color.r, sr.material.color.g, sr.material.color.b, 1f);
                    yield return new WaitForSeconds(1.5f);
                    break;
                case "1":
                    sr.material.color = new Color(sr.material.color.r, sr.material.color.g, sr.material.color.b, 0f);
                    yield return new WaitForSeconds(0.3f);
                    break;
            }
        }
    }

    void StartBlinking()
    {
        StopCoroutine("Blink");
        StartCoroutine("Blink");
    }

    public void StopBlinking()
    {
        StopCoroutine("Blink");
    }

}
