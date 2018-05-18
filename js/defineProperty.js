/**
 * 
 */
function moreDefine()
{
	var book = {};
	
	Object.defineProperties(book,{
		_year:
		{
			value:2004
		},
		
		edition:
		{
			value:1
		},
		
		year:
		{
			get:function()
			{
				return this_year;
			},
			
			set:function(newValue)
			{
				if(newValue > 2004)
				{
					this._year = newValue;
					this.edition += 1;
				}
			}
		},
	});
	console.log(Object.getOwnPropertyDescriptor(book,"_year").value);
	console.log(Object.getOwnPropertyDescriptor(book,"_year").configurable);
}


function getSet()
{
	var book =
	{
			_year:2004,
			edition:1
	};
	
	Object.defineProperty(book,"year",{
		get:function()
		{
			return this._year;
		},
		
		set:function(newValue)
		{
			if(newValue > 2004)
			{
				this._year = newValue;
				this.edition += newValue - 2004;
			}
		}
	});
	
	book.year = 2008;
	console.log(book.year);
	console.log(book.edition);
}

function deproperty()
{
	var person = {};
	Object.defineProperty(person,"name",{
		writable:false,
		value:"nike",
		configurable:false
	});
	console.log(person.name);
	person.name = "aaa";
	console.log(person.name);

	delete person.name;
	console.log(person.name);	
}