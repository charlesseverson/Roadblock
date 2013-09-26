using UnityEngine;
using System.Collections;

public class alien : MonoBehaviour 
	{
	///if(col.gameObject.name == "prop_powerCube")
	
	/// <summary>
	/// Raises the collision enter event.
	/// </summary>
	/// <param name='col'>
	/// Col.
	/// </param>
	
	void OnCollisionEnter( Collision col )
		{
		Destroy( gameObject );
		}
	}

