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
		publicProperty:true,
	
		publicMethod:function()
		{
			privateVaribale++;
			return privateFunction();
		}
	};
}();

var singletonTwo = function()
{
	var privateVaribale = 10;
	
	function privateFunction()
	{
		return false;
	}
	
	var obj = {};
	obj.publicProperty = true;
	obj.publicMethod = function()
	{
		privateVaribale++;
		return privateFunction();
	};
	
	return obj;
}();