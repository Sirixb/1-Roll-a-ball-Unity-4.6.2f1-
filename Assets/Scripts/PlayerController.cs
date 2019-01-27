using UnityEngine;
using UnityEngine.UI;//unity 5
using System.Collections;
//algunas cosas que estan comentadas son de la actualizacion de unity 5 en el projecto roll a ball.
public class PlayerController : MonoBehaviour 
{
	public float speed;
	public GUIText countText;
	//public Text countTex; //este lo realizaron con un Ui canvas text.
	public GUIText winText;
	//public Text winText; //este lo realizaron con un Ui canvas text.
	private int count;
	//private Rigidbody rb;

	void Start()
	{
		//rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	void FixedUpdate()
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3(moveHorizontal,0.0f, moveVertical);
			
			rigidbody.AddForce(movement*speed*Time.deltaTime);
			//rb.AddForce (movement * speed);
		}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			count= count+1; 
			SetCountText ();
		}
		/*if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
		}*/
	}
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "TU GANAS!";
		}
	}
}
