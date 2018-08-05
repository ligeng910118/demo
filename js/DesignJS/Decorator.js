var decorator = function(dom,fn)
{
	var dom = document.getElementById(dom);
	if(typeof dom.onclick === 'function')
	{
		var oldClickFn = dom.onclick;
		dom.onclick = function()
		{
			oldClickFn();
			fn();
		}
	}else{
		dom.onclick = fn;
	}
}