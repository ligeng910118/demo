/**
 * 
 */

function a()
{
	var result = new Array();
	for(var i = 0 ; i < 10 ; i++)
	{
		result[i] = function()
		{
			console.log(i);
			return i;
		};
		result[i]();
	}
	return result;
}

function b()
{
	function MyObject()
	{
		var privateVariale = 10;
		
		function privateFunction()
		{
			return false;
		}
		
		this.publicMethod = function()
		{
			privateVariable++;
			return privateFunction();
		};
	}
}