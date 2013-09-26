
function Update () 
	{
	var halfW:float = Screen.width/25;
	transform.position.x = (Input.mousePosition.x - halfW)/halfW;
	
	}