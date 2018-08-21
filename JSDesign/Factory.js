//Factory：由一个工厂对象决定创建某一种产品对象类的实例。主要创建同一类对象。
var Basketball = function()
{
	this.intro = "Basketball";
}

Basketball.prototype = {
	getMember : function()
	{
		console.log('five');
	},
	getBallSize : function()
	{
		console.log("Basketball big");
	}
}

var Football = function()
{
	this.intro = "Football";
}

Football.prototype = {
	getMember : function()
	{
		console.log('eleven');
	},
	getBallSize : function()
	{
		console.log("Football big");
	}
}

var Tennis = function()
{
	this.intro = "Tennis";
}

Tennis.prototype = {
	getMember : function()
	{
		console.log('one');
	},
	getBallSize : function()
	{
		console.log("Tennis small");
	}
}

var SportsFactory = function(name)
{
	switch(name)
	{
		case 'Basketball':
			return new Basketball();
		case 'Tennis':
			return new Tennis();
		case 'Football':
			return new Football();
	}
}
//实例化对象创建，如果父类继承同一父类，其方法可以共用。
// var football = SportsFactory("Football");
// football.getBallSize();

function createBook(name,time,type)
{
	var o = new Object();
	o.name = name;
	o.time = time;
	o.type = type;
	o.getName = function()
	{
		console.log(this.name);
	};
	return o;
}
//创建新对象包装增强其属性和功能，生成一个新对象。其方法不能共用
var book1 = createBook("js book",2014,"js");
book1.getName();