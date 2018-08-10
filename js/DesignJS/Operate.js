var A = function(selector)
{
	return new A.fn.init(selector);
}
A.fn = A.prototype = {
	constructor : A,
	element : null,
	length : 2,
	init : function(selector)
	{	
		this.element = document.getElementById(selector);
		this.length = 1;
		return this;
	},
	size : function()
	{
		return this.length;
	}
}
A.fn.init.prototype = A.fn;
console.log(A('interpreter'));