/**
 * 
 */

var singleton = function()
{
	var privateVaribale = 10;
	
	function privateFunction()
	{
		return false;
	}
	
	return {
		publicProperty:true;
	
		publicMethod:function()
		{
			privateVaribale++;
			return privateFunction();
		}
	}
}