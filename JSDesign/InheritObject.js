function inheritObject(o)
{
	function F(){}
	F.prototype = o;
	return new F();
}

var book = {
	name : "js book",
	alikeBook : ["css book","html book"],
	getName : function()
	{
		return this.name;
	},
	getAlikeBook : function()
	{
		return this.alikeBook;
	}
};

var newBook = inheritObject(book);
newBook.name = "ajax book";
newBook.alikeBook.push("xml");
console.log(newBook);

var otherBook = inheritObject(book);
console.log(otherBook);
