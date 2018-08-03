var Human = function(param)
{
	this.skill = param && param.skill || 'no data';
	this.hobby = param && param.hobby || 'no data';
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
			that.secondName = name.slice(name.indexOf(' '));
		}
	})(name,that);
}

var Work =  function(work)
{
	var that = this;
	(function(work,that){
		switch(work)
		{
			case 'code':
				that.work = 'engerneer';
				that.workDescript = ' coding for every day';
				break;
			case 'UI':
			case 'UE':
				that.work = 'designer';
				that.workDescript = " design like art";
				break;
			case 'teach':
				that.work = 'teacher';
				that.workDescript = 'share is happier';
				break;
			default :
				that.work = work;
				that.workDescript = " sorry, we can't know you check job";
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

var person = new Person("xiao ming",'code');
console.log(person);