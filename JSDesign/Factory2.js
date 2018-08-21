// factory2 ： 对产品类的抽象使其创建业务主要负责用于创建多累产品的实例
var Factory = function(type,content)
{
	if(this instanceof Factory)
	{
		return new this[type](content);
	}else{
		return new Factory(type,content);
	}
}

Factory.prototype = {
	Java : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.color = 'green';
			document.getElementById('container').appendChild(div);
		})(content);
	},

	Php : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.color = 'yellow';
			div.style.background = 'red';
			document.getElementById('container').appendChild(div);
		})(content);
	},

	Javascript : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.background = 'pink';
			document.getElementById('container').appendChild(div);
		})(content);
	},

	UI : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.background = 'blue';
			document.getElementById('container').appendChild(div);
		})(content);
	}
}

var data = [
	{type:'Javascript',content:'Javascript'},
	{type:'UI',content:'UI'},
	{type:'Php',content:'Php'},
	{type:'Java',content:'Java'},
];
for(var i = (data.length -1); i >= 0; i--)
{
	Factory(data[i].type,data[i].content);
}