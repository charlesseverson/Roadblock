using UnityEngine;
using System.Collections;

public class Galaga : MonoBehaviour 
	{
	
	/// <summary>
	/// The axis position z.
	/// </summary>
	
	public static float axisPositionZ = 0;
	
	/// <summary>
	/// The axis position y.
	/// </summary>
	
	public float axisPositionY = 0;
	
	/// <summary>
	/// The wall on either x.
	/// </summary>
	
	public static float wall = 18.16f;
	
	/// <summary>
	/// The position t.
	/// </summary>
	
	private Transform positionT;
	
	/// <summary>
	/// The galaga speed.
	/// </summary>
	
	public float galagaSpeed = 30;
	
	/// <summary>
	/// Awake this instance.
	/// </summary>
	
	void Awake()
		{
		positionT = transform;	
		}
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	
	void Start ()
		{
		positionT.position = new Vector3(0, axisPositionY,axisPositionZ);
		}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	
	void Update () 
		{
		if(Input.GetAxis("Horizontal") != 0)
			{	
			positionT.position = new Vector3(positionT.position.x + Input.GetAxis("Horizontal") * galagaSpeed * Time.deltaTime, axisPositionY, axisPositionZ);
			
			if(positionT.position.x < -wall + 1f)
				{
				positionT.position = new Vector3(-wall + 1f, axisPositionY, axisPositionZ);
				}
			
			else if(positionT.position.x > wall - 1f)
				{
				positionT.position = new Vector3(wall - 1f, axisPositionY, axisPositionZ);
				}
			}
		}
	}