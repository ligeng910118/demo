var Book = function(id,bookname,price)
{
	this.id = id;
	this.bookname = bookname;
	this.price = price;
}

Book.prototype = {
	display:function()
	{

	}
}
var book = new Book(10,"javascript design",50);
console.log(book.bookname);