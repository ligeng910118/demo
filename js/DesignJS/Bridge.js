var changeColor = function(dom,color,bg)
{
	dom.style.color = color;
	dom.style.background = bg;
}

// var spans = document.getElementsByTagName('span');
// span[0].onmouseover = function()
// {
// 	changeColor(this,'red','#ddd');
// }

var Speed = function(x,y)
{
	this.x = x;
	this.y = y;
}
Speed.prototype.run = function()
{
	console.log("running");
}

var Color = function(cl)
{
	this.color = cl;
}
Color.prototype.draw = function()
{
	console.log('drawing');
}

var Speek = function(wd)
{
	this.word = wd;
}
Speek.prototype.say = function()
{
	console.log('Speek');
}

//_________________________________________________

var Ball = function(x,y,c)
{
	this.speed = new Speed(x,y);
	this.color = new Color(c);
}
Ball.prototype.init = function()
{
	this.speed.run();
	this.color.draw();
}


var People = function(x,y,f)
{
	this.speed = new Speed(x,y);
	this.font = new Speek(f);
}
People.prototype.init = function()
{
	this.speed.run();
	this.font.say();
}

var p = new People(10,12,18);
p.init();
console.log(p);