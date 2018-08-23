//decorator : 在不改变对象的基础上，通过对其包装扩展（添加属性和方法）
//使原有对象可以满足用户的更复杂的需求
var decorator = function(input,fn)
{
	var input = document.getElementById("input");

	if(typeof input.onclick === 'function')
	{
		var oldEvent = input.onclick;
		input.onclick = function()
		{
			oldEvent();
			fn();
		}
	}else{
		input.onclick = fn;
	}
}