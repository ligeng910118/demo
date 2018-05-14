function Person(name)
{
	this.name = name;
}

Person.prototype.getName() = function()
{
	return this.name;
}

//inhert

function Author(name,books)
{
	Person.call(this,name);
	this.books = books;
}

Author.prototype = new Person();
Author.prototype.constructor = Author;
Author.prototype.getBooks = function()
{
	return this.books;
}