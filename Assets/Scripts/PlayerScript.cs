using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Speed = 25f;
    //public float Tilt = 1.2f;
    public float MinX;
    public float MaxX;
    public float MinY;
    public float MaxY;

    private Rigidbody2D _player;

    // Start is called before the first frame update
    private void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var moveHorizontal = Input.GetAxisRaw("Horizontal");
        var moveVertical = Input.GetAxisRaw("Vertical");

        _player.velocity = new Vector2(moveHorizontal, moveVertical) * Speed;
        //_player.rotation = Quaternion.Euler(_player.velocity.z * Tilt, 0, -_player.velocity.x * Tilt);

        var posX = Mathf.Clamp(_player.position.x, MinX, MaxX);
        var posY = Mathf.Clamp(_player.position.y, MinY, MaxY);

        _player.position = new Vector2(posX, posY);

    }
}
