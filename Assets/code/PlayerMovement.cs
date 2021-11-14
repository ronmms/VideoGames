using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Animator animator;
	public float speed = 0.0001f;
	float horizontalMove = 0f;

	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position -= transform.right * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.Space))
		{
			transform.position += transform.up * 20 * Time.deltaTime;
			animator.SetBool("IsJumping", true);
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		animator.SetBool("IsJumping", false);

	}
}