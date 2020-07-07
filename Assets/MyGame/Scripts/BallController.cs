using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool pressButton;
    [SerializeField] float speed = 6;
    [SerializeField] float speedBall = 12;
    [SerializeField] float limit = 4;
    float horizontal;
    float valueButton;
    Rigidbody rigid;
    float maxVel = 50;
    //Vector3 limitVelocity = new Vector3(0, this.transfrom.position, 50);
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveBall();

    }

    void MoveBall()
    {
        if (rigid.velocity.z < maxVel)
        {
            rigid.AddForce(Vector3.forward * speedBall, ForceMode.Acceleration);
            //Debug.Log("Velocity: " + rigid.velocity);
        }
#if UNITY_STANDLONE
        valueButton = Input.GetAxis("Horizontal");
#endif

#if UNITY_ANDROID || UNITY_IOS
        if(pressButton)
        {

        }
#endif

        horizontal = valueButton * Time.deltaTime * speed;
        transform.Translate(new Vector3(horizontal, 0, 0));

        // initially, the temporary vector should equal the player's position
        Vector3 clampedPosition = transform.position;
        // Now we can manipulte it to clamp the y element
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -limit, limit);
        // re-assigning the transform's position will clamp it
        transform.position = clampedPosition;
    }

    void ButtonRight()
    {
        valueButton = 1;
        pressButton = true;
    }

    void ButtonLeft()
    {
        valueButton = -1;
    }

}
