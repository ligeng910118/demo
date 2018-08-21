function SuperClass()
{
	this.superValue = true;
	this.book = ["aa","bb"];
}

SuperClass.prototype.getSuperValue = function()
{
	return this.superValue;
};

function SubClass()
{
	this.subValue = false;
	
}

SubClass.prototype = new SuperClass();
SubClass.prototype.constructor = SubClass;

SubClass.prototype.getSubValue = function()
{
	return this.subValue;
};

var a = new SubClass();
var v = new SubClass();
v.book.push("vv");
console.log(v);
console.log(a);
