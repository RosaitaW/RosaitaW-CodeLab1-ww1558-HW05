using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D playerCollider;
    public float force;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public static playerController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World! ");
        playerCollider = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))//if D is pressed
        {
            playerCollider.AddForce(Vector2.right * force);//apply a force using the "force" var
        }
        else if (Input.GetKey(left))
        {
            playerCollider.AddForce(Vector2.left * force);
        }
        else if (Input.GetKey(up))
        {
            playerCollider.AddForce(Vector2.up * force);
        }
        else if (Input.GetKey(down))
        {
            playerCollider.AddForce(Vector2.down * force);
        }
    }
}
