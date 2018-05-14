
var Book = function(isbn,title,author)
{
	this.setIsbn(isbn);
	this.setTitle(title);
	this.setAuthor(author);
}

Book.prototype= {
		getIsbn:function()
		{
			return this._isbn;
		},

		setIsbn:function(isbn)
		{
			if(isbn == undefined)
				throw new Error('book constructor requires an isbn');
			this._isbn = isbn;
		},
		
		getTitle:function()
		{
			return this._title;
		},

		setTitle:function(title)
		{
			this._title = title || "no title specified";
		},
		
		getAuthor:function()
		{
			return this._author;
		},

		setAuthor:function(author)
		{
			this._author = author || "no author specified";
		},
		display : function()
		{
			return "isbn:"+this.getIsbn()+", title:"+this.getTitle()+", author:"+this.getAuthor();
		},
};