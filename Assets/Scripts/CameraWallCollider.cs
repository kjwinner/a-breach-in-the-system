using UnityEngine;
using System.Collections;

/*
The CameraWallCollider class allows the player to see the Player when the Player is backed against
a wall.  The Wall is made transparent to achieve this.
*/
public class CameraWallCollider : MonoBehaviour {
	
	
	Shader shader1;	//oldShader
	Shader shader2;	//new Shader
	Color color1;	//old Color
	Color color2;	//new Color
	
	/*
	The Start function instantiates the new Shader and Color.
	*/
	void Start()
	{
		shader2 = Shader.Find("Transparent/VertexLit");
		color2 = Color.clear;
	}
	
	/*
	The OnTriggerEnter function makes transparent the wall.
	*/
	void OnTriggerEnter(Collider other)
	{
		shader1 = other.gameObject.GetComponent<Renderer>().material.shader;
		color1 = other.gameObject.GetComponent<Renderer>().material.color;
		other.gameObject.GetComponent<Renderer>().material.shader = shader2;
		other.gameObject.GetComponent<Renderer>().material.color = color2;
	}
	
	/*
	The OnTriggerExit function makes the wall opaque again.
	*/
	void OnTriggerExit(Collider other)
	{
		other.gameObject.GetComponent<Renderer>().material.shader = shader1;
		other.gameObject.GetComponent<Renderer>().material.color = color1;
	}
}
