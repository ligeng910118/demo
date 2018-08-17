var CheckObject = function(){
	return {
			checkName : function()
			{
				console.log('checkName');
			},
			checkEmail : function()
			{
				console.log('checkEmail');
			},
			checkPassword : function()
			{
				console.log('checkPassword');
			},
	}

}

// var a = CheckObject();
// a.checkEmail();

var CheckClass = function()
{

}

CheckClass.prototype = {
			checkName : function()
			{
				console.log('checkName');
				return this;
			},
			checkEmail : function()
			{
				console.log('checkEmail');
				return this;
			},
			checkPassword : function()
			{
				console.log('checkPassword');
				return this;
			},
}

var a = new CheckClass();
a.checkEmail().checkName();