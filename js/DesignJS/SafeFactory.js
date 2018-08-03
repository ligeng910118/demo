var Factory = function(type,content)
{
	if(this instanceof Factory)
	{
		return new this[type](content);
	}else{
		return new Factory(type,content);
	}
}

Factory.prototype = 
{
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
	JavaScript : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.color = 'red';
			document.getElementById('container').appendChild(div);
		})(content);
	},
	UI : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.color = 'yellow';
			document.getElementById('container').appendChild(div);
		})(content);
	},
	PHP : function(content)
	{
		this.content = content;
		(function(content){
			var div = document.createElement('div');
			div.innerHTML = content;
			div.style.color = 'blue';
			document.getElementById('container').appendChild(div);
		})(content);
	}
}

var data = [
	{type:'JavaScript',content:'JavaScript'},
	{type:'Java',content:'Java'},
	{type:'PHP',content:'PHP'},
	{type:'UI',content:'UI'},
	{type:'UI',content:'UI'},
	{type:'JavaScript',content:'JavaScript'},
	{type:'JavaScript',content:'JavaScript'},
];

for (var i = 0; i < data.length; i++)
{
	Factory(data[i].type,data[i].content);
}