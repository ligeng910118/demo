var Ming = {
	g : function(id)
	{
		return document.getElementById(id);
	},
	css : function(id,key,value)
	{
		this.g(id).style[key] = value;
	}
}

var A = {
	Util : {
		util_menthod1 : function(){},
		util_menthod2 : function(){}
	},
	Tool : {
		tool_method1 : function(){},
		tool_method2 : function(){}
	},
	Ajax : {
		get : function(){},
		post : function(){}
	}
}

