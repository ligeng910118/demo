var addEvent = function(dom,type,fn)
{
	if(dom.addEventListener)
	{
		dom.addEventListener(type,fn,false);
	}else if(dom.attachEvent){
		dom.attachEvent('on'+type,fn);
	}else{
		dom['on'+type] = fn;
	}
}

var container = document.getElementById('container');
addEvent(container,'click',function(){
	console.log("one");
});
addEvent(container,'click',function(){
	console.log("two");
});

var A = {
	g : function(id)
	{
		return document.getElementById(id);
	},
	css : function(id,key,value)
	{
		this.g(id).style[key] = value;
	},
	attr : function(id,key,value)
	{
		this.g(id)[key] = value;
	},
	html : function(id,html)
	{
		this.g(id).innerHTML = html;
	},
	on : function(id,type,fn)
	{
		this.g(id)['on'+type] = fn;
	}
};
A.css('container','background','red');
A.attr('container','className','container');
A.on('container','click',function(){
	A.html('container','new container');
});