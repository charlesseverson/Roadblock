using UnityEngine;
using System.Collections;

public class ball2 : MonoBehaviour {
	
	/// <summary>
	/// The multiplier.
	/// </summary>
	
	public float mult = 1.1f;
	
	/// <summary>
	/// The minimum.
	/// </summary>
	
	public float min = 2;
	
	/// <summary>
	/// The max.
	/// </summary>
	
	public float max = 12;
	
	/// <summary>
	/// The current speed.
	/// </summary>
	
	public float currentSpeed = 0;
	
	/// <summary>
	/// The position t.
	/// </summary>
	
	private Transform positionT;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
		
	void Start () 
		{
		Reset();
		}
	
	/// <summary>
	/// Awake this instance.
	/// </summary>
	
	void Awake()
		{
		positionT = transform;
		}
	
	/// <summary>
	/// Update this instance.
	/// </summary>
	
	void Update () 
		{
		if(positionT.position.y < -7)
			{	
			Reset();
			}
		}
	
	///function FixedUpdate () {
	///	rigidbody.AddForce (Vector3.up);
	///}
	
	///var magnitude: float;
	///Description
	///Returns the length of this vector (Read Only).
	
	/// <summary>
	/// Fixeds the update.
	/// </summary>
	
	void FixedUpdate()
		{
		currentSpeed = Vector3.Magnitude( rigidbody.velocity);
		
		if (currentSpeed > max ) 
			{
			rigidbody.velocity /= currentSpeed / max;
			}
		if (currentSpeed < min && currentSpeed > 0)
			{
			rigidbody.velocity /= currentSpeed / max;
			}
		
		///if (currentSpeed == 0)
		}
		
	
	///if(col.gameObject.name == "prop_powerCube")
	
	/// <summary>
	/// Raises the collision enter event.
	/// </summary>
	/// <param name='col'>
	/// Col.
	/// </param>

	void OnCollisionEnter( Collision col )
		{
		rigidbody.velocity += rigidbody.velocity * mult;
		}
	
	/// <summary>
	/// Miss this instance.
	/// </summary>
	
	private void Miss()
		{
		Reset();
		}
	
	///function Reset () {
		// Only set target if it is not assigned yet.
	///	if (!target)
	///		target = GameObject.FindWithTag ("Player");
	///}
	
	///var prefab : GameObject;
	///function Start () {
	///	var position: Vector3 = Vector3(Random.Range(-10.0, 10.0), 0, Random.Range(-10.0, 10.0));
	///	Instantiate(prefab, position, Quaternion.identity);
	///}
	
	///function Update() {
	///	transform.LookAt(target);
	///}
	
	///function Start()
	///{
	///	if (respawns == null)
	///		GameObject.FindGameObjectsWithTag ("Respawn");
	///	for (var respawn in respawns)
	///		Instantiate (respawnPrefab, respawn.transform.position, respawn.transform.rotation);
	///}
	
	
	///function FixedUpdate () {
	///	rigidbody.AddRelativeForce (Vector3.forward * 10);
	///}
	
	/// <summary>
	/// Reset this instance.
	/// </summary>
	
	private void Reset()
		{
		currentSpeed = 2;
		positionT.position = new Vector3( Random.Range( Galaga.wall + 2, 1), 0, Galaga.axisPositionZ);
		positionT.LookAt(GameObject.FindGameObjectWithTag( "Galaga" ).transform.position);
		rigidbody.AddRelativeForce(new Vector3(0, 0, min));
		}
	
}
