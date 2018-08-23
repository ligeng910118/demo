// template ： 父类中定义一组操作算法骨架，而讲一些实现步骤延迟到子类中
//使子类可以不改变父类的算法结构的同时重新定义算法中某些实现步骤

var Alert = function(data)
{
	if(!data)
		return;

	this.content = data.content;

	this.panel = document.createElement('div');
	this.panel.className = 'alert';

	this.contentNode = document.createElement('p');
	this.contentNode.innerHTML = this.content;

	this.confirmBtn = document.createElement('span');
	this.confirmBtn.className = 'a-confirm';
	this.confirmBtn.innerHTML = data.confirm || 'confirm';

	this.closeBtn = document.createElement('b');
	this.closeBtn.className = 'a-close';

	this.success = data.success || function(){};
	this.fail = data.fail || function(){};
}

Alert.prototype = {
	
}