function SuperClass(id)
{
	this.book = ["aa","vv"];
	this.id = id;
}

SuperClass.prototype.showBooks = function()
{
	console.log(this.id);
}

function SubClass(id)
{
	SuperClass.call(this,id);
}

SubClass.prototype = new SuperClass();

var a = new SubClass(20);
console.log(a);
console.log(a.showBooks());
