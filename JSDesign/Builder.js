//builder :将一个复杂的构建层与其表示层相互分离，同样的构建过程可采用不同的表示
var Human = function(param)
{
	this.skill = param && param.skill || '保密';
	this.hobby = param && param.hobby || '保密';
}

Human.prototype = {
	getSkill : function()
	{
		return this.skill;
	},
	getHobby : function()
	{
		return this.hobby;
	}
}

var Named = function(name)
{
	var that = this;
	(function(name,that){
		that.wholeName = name;
		if(name.indexOf(' ') > -1)
		{
			that.FirstName = name.slice(0,name.indexOf(' '));
			that.SecondName = name.slice(name.indexOf(' '));
		}
	})(name,that);
}

var Work = function(work)
{
	var that = this;
	(function(work,that){
		switch(work)
		{
			case 'code':
				that.work = "coder";
				that.workDescript = 'like coding';
				break;
			case 'UI':
			case 'UE':
				that.work = "designer";
				that.workDescript = 'like designning';
				break;
			case 'teach':
				that.work = 'teacher';
				that.workDescript = "like teaching";
				break;
			default:
				that.work = work;
				that.workDescript = "sorry"
		}
	})(work,that);
}

Work.prototype.changeWork = function(work)
{
	this.work = work;	
}

Work.prototype.changeDescript = function(setence)
{
	this.workDescript = setence;
}

var Person = function(name,work)
{
	var _person = new Human();
	_person.name = new Named(name);
	_person.work = new Work(work);
	return _person;
}

var xiaoming = new Person("xiao ming",'code');
console.log(xiaoming);
console.log(xiaoming.name.FirstName);