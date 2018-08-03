var Basketball = function()
{
	this.intro = "Basketball";
}
Basketball.prototype = 
{
	getMember : function()
	{
		console.log("five");
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
Football.prototype = 
{
	getMember : function()
	{
		console.log("eleven");
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
Tennis.prototype = 
{
	getMember : function()
	{
		console.log("one");
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
		case 'Football':
			return new Football();
		case 'Tennis':
			return new Tennis();
	}
}
	var football = SportsFactory("Football");
	console.log(football);
	console.log(football.getBallSize);
	football.getBallSize();
