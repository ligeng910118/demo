//composite ： 将对象组合成树形结构以表示"部分整体"的层次结构。组合模式使用户对单个对象和组合对象的使用的一致性
function inheritPrototype(subType,superType)
{
    var prototype=Object.create(superType.prototype);//创建对象
    prototype.construct=subType;//增强对象
    subType.prototype=prototype;//指定对象
}

var News = function()
{
	this.children = [];
	this.element = null;
}

News.prototype = {
	init : function()
	{
		throw new Error("rewrite function");
	},
	add : function()
	{
		throw new Error("rewrite function");
	},
	getElement : function()
	{
		throw new Error("rewrite function");
	},
}

var Container = function(id,parent)
{
	News.call(this);
	this.id = id;
	this.parent = parent;
	this.init();
}

inheritPrototype(Container,News);

Container.prototype.init = function()
{
	this.element = document.createElement('ul');
	this.element.id = this.id;
	this.element.className = 'new-container';
};

Container.prototype.add = function(child)
{
	this.children.push(child);
	this.element.appendChild(child.getElement());
	return this;
};

Container.prototype.getElement = function()
{
	return this.element;
}

Container.prototype.show = function()
{
	this.parent.appendChild(this.element);
}

var Item = function(classname)
{
	News.call(this);
	this.classname = classname || '';
	this.init();
}

inheritPrototype(Item,News);

Item.prototype.init = function()
{
	this.element = document.createElement('li');
	this.element.className = this.classname;
}

Item.prototype.add = function(child)
{
	this.children.push(child);
	this.element.appendChild(child.getElement());
	return this;
}

Item.prototype.getElement = function()
{
	return this.element;
}

var NewsGroup = function(classname)
{
	News.call(this);
	this.classname = classname || '';
	this.init();
}

inheritPrototype(NewsGroup,News);

NewsGroup.prototype.init = function()
{
	this.element = document.createElement('div');
	this.element.className = this.classname;
}

NewsGroup.prototype.add = function(child)
{
	this.children.push(child);
	this.element.appendChild(child.getElement());
	return this;
}

NewsGroup.prototype.getElement = function()
{
	return this.element;
}

var ImageNews = function(url,href,classname)
{
	News.call(this);
	this.url = url || '';
	this.href = href || '#';
	this.classname = classname || 'normal';
	this.init();
}

inheritPrototype(ImageNews,News);

ImageNews.prototype.init = function()
{
	this.element = document.createElement('a');
	var img = new Image();
	img.src = this.url;
	this.element.appendChild(img);
	this.element.className = 'image-news ' + this.classname;
	this.element.href = this.href;
}

ImageNews.prototype.add = function(){}

ImageNews.prototype.getElement = function()
{
	return this.element;
}

var IconNews = function(text,href,type)
{
	News.call(this);
	this.text = text || '';
	this.href = href || '#';
	this.type = type || 'video';
	this.init();
}

inheritPrototype(IconNews,News);

IconNews.prototype.init = function()
{
	this.element = document.createElement('a');
	this.element.innerHTML = this.text;
	this.element.href = this.href;
	this.element.className = 'icon ' + this.type;
}

IconNews.prototype.add = function() {}

IconNews.prototype.getElement = function()
{
	return this.element;
}

var EasyNews = function(text,href)
{
	News.call(this);
	this.text = text || '';
	this.href = href || '#';
	this.init();
}

inheritPrototype(EasyNews,News);

EasyNews.prototype.init = function()
{
	this.element = document.createElement('a');
	this.element.innerHTML = this.text;
	this.element.href = this.href;
	this.element.className = 'text';
}

EasyNews.prototype.add = function(){}

EasyNews.prototype.getElement = function()
{
	return this.element;
}

var TypeNews = function(text,href,type,pos)
{
	News.call(this);
	this.text = text || '';
	this.href = href || '#';
	this.type = type || '';
	this.pos = pos || 'left';
	this.init();
}

inheritPrototype(TypeNews,News);

TypeNews.prototype.init = function()
{
	this.element = document.createElement('a');
	if(this.pos === 'left')
	{
		this.element.innerHTML = '[' + this.type + ']' + this.text;
	}else{
		this.element.innerHTML = this.text + '[' + this.type + ']';
	}
	this.element.href = this.href;
	this.element.className = 'text';
}

TypeNews.prototype.add = function(){}

TypeNews.prototype.getElement = function()
{
	return this.element;
}

var news1 = new Container('news',document.body);
console.log(news1);
news1.add(
	new Item('normal').add(new IconNews('梅西不拿金球也伟大','#','video'))
	).add(
	new Item('normal').add(new IconNews('保护强国强队泳衣明显','#','live'))
	).add(
		new Item('normal').add(
			new NewsGroup('has-img').add(
				new ImageNews('img/1.jpg','#','small')
			).add(
				new EasyNews('减肥记','#')
			).add(
				new EasyNews('跑步机','#')
			)
		)
	).add(
	new Item('normal').add(new TypeNews('AK47不愿为费城打球','#','nba','left'))
	).add(
	new Item('normal').add(new TypeNews('火炮飚6三分创新高','#','cba','right'))
	).show();