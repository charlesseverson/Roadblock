private var limit: float = 0.01;
private var cycles: int;
private var cyclesToSleep: int = 10;

function FixedUpdate () {
	if (rigidbody.velocity.sqrMagnitude > limit){
		cycles = cyclesToSleep; // reload counter if velocity isn't negligible
	}
	if (cycles > 0){ // while counter > 0 apply force
		cycles--;
		rigidbody.AddForce(Physics.gravity);
	}
}