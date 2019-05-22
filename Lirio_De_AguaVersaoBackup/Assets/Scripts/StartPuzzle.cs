using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPuzzle : MonoBehaviour
{

    public GameObject _canvasHUD;
    public GameObject _player;
    public GameObject _playerCamera;
    public GameObject _puzzleCamera;
    private bool puzzleEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChangeCamera()
    {
        if (puzzleEnabled)
        {
            _playerCamera.SetActive(false);
            _puzzleCamera.SetActive(true);
            _canvasHUD.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            _playerCamera.SetActive(true);
            _puzzleCamera.SetActive(false);
            _canvasHUD.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            puzzleEnabled = !puzzleEnabled;
            ChangeCamera();
        }
    }

}
