/**
 * 
 */

function kk()
{
	var person = 
	{
		name:"nicker",
		friends:["one","two"]
	};
	
	var p = Object.create(person);
	p.name ="gerg";
	p.friends.push("three");
	console.log(p);
	var v = Object.create(person);
	v.name ="rog";
	v.friends.push("four");
	console.log(v)
}

function jj()
{
	function SuperType(name)
	{
		this.name = name;
		this.colors = ["red","blue","green"];
	}
	
	SuperType.prototype.SuperTypeSay = function()
	{
		console.log(this.name,this.colors);
	}
	
	function SubType(name,age)
	{
		SuperType.call(this,name);
		this.age = age;
	}
	
	SubType.prototype = new SuperType();
	SubType.prototype.constructor = SubType;
	
	SubType.prototype.SubTypeSay = function()
	{
		console.log(this.name,this.age,this.colors);
	}
	
	var p = new SubType("nike",29);
	p.colors.push("black");
	var v = new SuperType("oop",2);
	console.log(p);
	console.log(v);
	
}

function ii()
{
	function SuperType(name)
	{
		this.name = name;
	}
	
	SuperType.prototype.SuperTypeSay = function()
	{
		console.log(this.name);
	}
	
	function SubType(name,age)
	{
		SuperType.call(this,name);
		this.age = age;
	}
	
	SubType.prototype.SubTypeSay = function()
	{
		console.log(this.name,this.age);
	}
	
	
}

function hh()
{
	function SuperType(name)
	{
		this.name = name;
	}
	
	function SubType(name,age)
	{
		SuperType.call(this,name);
		this.age = age;
	}
	
	var p = new SubType("nike",11);
	console.log(p.age);
	console.log(p.name);
}

function gg()
{
	function SuperType()
	{
		this.colors = ["red","blue","green"];
	}
	
	function SubType()
	{
		SuperType.call(this);
	}
	var v = new SuperType();
	var p = new SubType();
	p.colors.push("black");
	console.log(p.colors);
	console.log(v.colors);
}

function ff()
{
	function SuperType()
	{
		this.property = "super type";
	}
	
	SuperType.prototype.getSuperValue = function()
	{
		return this.property;
	};
	
	function SubType()
	{
		this.subproperty = "sub type";
	}


	SubType.prototype = new SuperType();

	SubType.prototype.getSubValue = function()
	{
		return this.subproperty;
	};
	
	var p = new SubType();
	console.log(p);
}

function ee()
{
	function Person(name,age,job)
	{
		this.name = name;
		this.job = job;
		this.age = age;
		this.friends = ["shelly","court"];
	}
	
	Person.prototype =
	{
			constructor:Person,
			say:function()
			{
				console.log(this.friends);
			}
	};
	
	var p = new Person("nike",29,"software engineer");
	p.friends.push("van");
	var v = new Person("greg",27,"doctor");
	p.say();
	v.say();
}

function dd()
{
	function Person(name,age,job)
	{
		this.name = name;
		this.age = age;
		this.job = job;
		this.say = function()
		{
			console.log(this.name);
			console.log(this.job);
		}
	}
	
	var p = new Person("nike",19,"techology");
	console.log(p);
	p.say();
	
	console.log(p.constructor == Person);
	console.log(p instanceof Object);
	console.log(p instanceof Person);
}

function cc()
{
	function createPerson(name,age,job)
	{
		var o = {};
		o.name = name;
		o.age = age;
		o.job = job;
		o.say = function()
		{
			console.log(this.name);
			console.log(this.job);
		}
		return o;
	}
	
	var p1 = createPerson("nicholas",29,"software engineer");
	p1.say();
}

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