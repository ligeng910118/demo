var Book = function(id,bookname,price)
{
	if(this instanceof Book)
	{
		this.id = id;
		this.bookname = bookname;
		this.price = price;
	}else{
		return new Book(id,bookname,price);		
	}

}

Book.prototype = {
	constructor:Book,
	display : function()
	{
		console.log('book display');
	}
}

// var book = new Book(10,'javascript',50);
// console.log(book);

var SuperClass = function()
{
	this.superValue = true;
}
SuperClass.prototype = {
	constructor : SuperClass,
	getSuperValue : function()
	{
		return this.superValue;
	}
}

var SubClass = function()
{
	this.subClass = false;
}



SubClass.prototype = new SuperClass();
SubClass.prototype.constructor = SubClass;
SubClass.prototype.getSubValue =function(){
		return this.subClass;
}
var b = new SubClass();
console.log(b);