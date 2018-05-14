var Book = (function(){
	var numOfBooks = 0;
	function checkIsbn(isbn)
	{
		
	}
	
	return  function(newIsbn,newTitle,newAuthor)
	{
		var isbn,title,author;
		
		this.getIsbn = function()
		{
			return isbn;
		};
		this.setIsbn = function(newIsbn)
		{
			if(!newIsbn)
				throw new Error("book:invalid isbn");
			isbn = newIsbn;
		};
		
		this.getTitle = function()
		{
			return title;
		};
		this.setTitle = function(newTitle)
		{
			title = newTitle || "no title";
		};
		
		this.getAuthor = function()
		{
			return author;
		};
		this.setAuthor = function(newAuthor)
		{
			author = newAuthor || "no author";
		};
		
		numOfBooks++;
		if(numOfBooks > 50)
			throw new Error("book:only 50 instances of book can be created.");
		this.setIsbn(newIsbn);
		this.setTitle(newTitle);
		this.setAuthor(newAuthor);
	}
})();

Book.convertToTitleCase = function()
{
	console.log(Book.numOfBooks);
};

Book.prototype = {
		display:function()
		{
			
		},
};
