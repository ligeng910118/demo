//bridge : 在系统多维变化的同时，又不增加其复杂度并达到解耦。
function changeStyle(dom,styleObject)
{
	for(var i in styleObject)
	{
		dom.style[i] = styleObject[i];
	}
}

// var spans = document.getElementsByTagName('span');
// spans[0].onmouseover = function()
// {
// 	changeStyle(this,{color:'red',background:'#ddd'});
// }
// spans[0].onmouseout = function()
// {
// 	changeStyle(this,{color:'white',background:'green'});
// }

function Speed(x,y)
{
	this.x = x;
	this.y = y;
}

Speed.prototype = {
	run : function()
	{
		console.log('run');
	}
}

function Color(cl)
{
	this.color = cl;
}

Color.prototype = {
	draw : function()
	{
		console.log('draw');
	}
}

function Shape(sp)
{
	this.shape = sp;
}

Shape.prototype = {
	change : function()
	{
		console.log('change');
	}
}

function Speek(wd)
{
	this.word = wd;
}

Speek.prototype =
{
	say : function()
	{
		console.log('say');
	}
}

//create ball
function Ball(x,y,z)
{
	this.speed = new Speed(x,y);
	this.color = new Color(z);
}

Ball.prototype = {
	init : function()
	{
		this.speed.run();
		this.color.draw();
	}
}
//create people
function people(x,y,f)
{
	this.speed = new Speed(x,y);
	this.speek = new Speek(f);
}

people.prototype = {
	init : function()
	{
		this.speed.run();
		this.speek.say();
	}
}

//create Spirite
function Spirite(x,y,c,s)
{
	this.speed = new Speed(x,y);
	this.color = new Color(c);
	this.shape = new Shape(s);
}

Spirite.prototype = {
	init : function()
	{
		this.speed.run();
		this.shape.change();
		this.color.draw();
	}
}

var s = new Spirite(10,11,12,13);
s.init();
