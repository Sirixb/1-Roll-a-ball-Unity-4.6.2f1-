using UnityEngine;
using System.Collections;
//Behaviour= comportamiento
public class CameraController : MonoBehaviour 
{
	//aca declaro una variable publica donde guardo las propiedades del jugador
	public GameObject player;
	// variable de desplazamiento
	private Vector3 offset;
	// Use this for initialization
	void Start () 
	{
		offset = transform.position;
		//offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// y cambio update por LateUpdate que es mejor para seguir y rercolectar los datos de las camaras
	void LateUpdate()
	{
		transform.position = player.transform.position + offset;

	}
}
