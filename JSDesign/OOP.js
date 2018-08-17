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

var book = new Book(10,'javascript',50);
console.log(book);