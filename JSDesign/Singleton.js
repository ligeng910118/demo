//Singleton: 只允许实例化一个对象类，一个对象来规划一个命名空间，管理对象的属性和方法
var Singleton = 
{
	getId : function(id)
	{
		return document.getElementById(id);
	},
	setCss : function(id,key,value)
	{
		this.getId(id).style[key] = value;
	},
	setAttr : function(id,key,value)
	{
		this.getId(id)[key] = value;
	},
	setHtml : function(id,value)
	{
		this.getId(id).innerHTML = value;
	},
	on : function(id,type,fn)
	{
		this.getId(id)['on' + type] = fn;
	}
};

console.log(Singleton.getId('container'))