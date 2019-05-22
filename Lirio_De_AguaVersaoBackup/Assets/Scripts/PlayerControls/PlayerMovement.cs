using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Movement Variables
    float acFoward = 0.5f;
    public float maxSwimSpeed;
    float spdV = 0;
    #endregion
    public float deadzone = 0.02f;
    public float joystickSensitivy = 3;
    CameraOrbit camOrb;
    float gravity = 5f;
    float initAngle;
    Rigidbody rb;
    public Animator anim;
    #region Pitch Variables
    public float pSpeed = 240.0f;
    public float pMinLimit = -80f;
    public float pMaxLimit = 80f;
    float p = 0.0f;
    #endregion
    #region Roll Variables
    #endregion
    #region Yaw Variables
    public float ySpeed = 120.0f;
    float y = 0.0f;
    #endregion
    private enum State {
        SwimClosed,
        SwimOpen,
        Cutscene,
        ActionEvents,
        Surface,
        Floating,
    }
    private State state;
    public bool isDoingPuzzle = false;

    // Terminar de arrumar as funções por estado e fazer o SwimFast (mecanica)

    // Start is called before the first frame update
    void Start()
    {
        camOrb = FindObjectOfType<CameraOrbit>();
        p = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
        rb = GetComponent<Rigidbody>();
        state = State.SwimOpen;
    }

    // Update is called once per frame
    void Update()
    {
        //StateHandler();
        AnimationUpdate();
        if (!isDoingPuzzle)
        {
            switch (state)
            {
                case State.SwimOpen:
                    Movement();
                    PitchRotation();
                    YawRotation();
                    ApplyRotation();
                    break;
                case State.SwimClosed:
                    break;
                case State.Floating:
                    YawRotation();
                    PitchRotation();
                    ApplyRotation();
                    Movement();
                    Float();
                    break;
            }
        }
        /*
        Debug.Log("LeftAnalogY = " + Input.GetAxis("LeftAnalogY"));
        Debug.Log("KeyboardY = " + Input.GetAxis("KeyboardY"));
        */
    }

    void AnimationUpdate()
    {
        float blendVelocity = spdV / maxSwimSpeed; // Basic 
        anim.SetFloat("zSpeed", blendVelocity);
    }

    void FloatingDiving()
    {

    }

    void Float()
    {
        if (state == State.Floating)
        {
            transform.position = new Vector3 (transform.position.x, -0.65f, transform.position.z);
        }
    }

    void StateHandler()
    {
        if (this.gameObject.transform.position.y > -1f)
        {
            state = State.Floating;
        }
        if (this.gameObject.transform.position.y < 1.5f)
        {
            state = State.SwimOpen;
        }
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetAxis("Triggers") > deadzone)
        {
            if (spdV < maxSwimSpeed)
            {
                spdV += acFoward * Time.deltaTime;
                spdV *= 1.02f;
            }
            //print(spdV);
        }
        else
        {
            if (spdV > 0.5f)
            {
                //spdV -= acFoward * Time.deltaTime;
                spdV *= 0.98f;
            }
            else
            {
                spdV = 0f;
            }
            //print(spdV);
        }
        if (spdV != 0)
            rb.MovePosition(transform.position + transform.forward * spdV * Time.deltaTime);
        else
        {
            rb.velocity = Vector3.zero;
        }
        //rb.velocity = transform.position + transform.forward * spdV * Time.deltaTime;
        //transform.Translate(0f, 0f, 1 * spdV * Time.deltaTime);
    }

    void PitchRotation()
    {
        if (state == State.SwimOpen || state == State.SwimClosed)
        {
            // The following if its just for cosmetic reasons reagarding my current animations.
            if (spdV < 2)
            {
                if (p > 0)
                {
                    p -= 15 * Time.deltaTime;
                }
                else
                {
                    p += 15 * Time.deltaTime;
                }
            }
            else
            {
                // The "normal" code would be just the following three lines.
                p += Input.GetAxis("LeftAnalogY") * pSpeed * joystickSensitivy * Time.deltaTime;
                p += Input.GetAxis("KeyboardY") * pSpeed * Time.deltaTime;
                p = ClampAngle(p, pMinLimit, pMaxLimit);
            }
        }
        else if(state == State.Floating)
        {
            if (p > 0)
            {
                p -= 15 * Time.deltaTime;
            }
            else
            {
                p += 15 * Time.deltaTime;
            }
        }
    }

    void YawRotation()
    {
        y += Input.GetAxis("LeftAnalogX") * ySpeed * joystickSensitivy * Time.deltaTime;
        y += Input.GetAxis("KeyboardX") * ySpeed * Time.deltaTime;
    }

    void ApplyRotation()
    {
        Quaternion rotation = Quaternion.Euler(p, y, 0);
        rb.MoveRotation(rotation);
        //transform.rotation = rotation;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }

    public void Jump()
    {
        
    }
}
