var sendData = function(data,dealType,dom)
{
	var xhr = new XMLHttpRequest(),
	url = 'getData.php?mod=userInfo';

	xhr.onload = function(event)
	{
		if((xhr.status >= 200 && xhr.status < 300) || xhr.status == 304)
		{
			dealData(xhr.responseText,dealType,dom);
		}else{
			throw new Error("ajax Error");
		}
	};

	for(var i in data)
	{
		url += '&' + i + '=' + data[i];
	}

	xhr.open("get",url,true);
	xhr.send(null);
}

var dealData = function(data,dealType,dom)
{
	var dataType = Object.prototype.toString.call(data);
	switch(dealType)
	{
		case 'sug':
			if(dataType === "[object Array]")
			{
				return createSug(data,dom);
			}
			if(dataType === "[object Object]")
			{
				var newData = [];
				for(var i in data)
				{
					newData.push(data[i]);
				}
				return createSug(newData,dom);
			}
			return createSug([data],dom);
			break;
		case 'validate':
			return createValidataResult(data,dom);
			break;
	}
}

var createSug = function(data,dom)
{
	var len = data.length,html = '';
	for(var i=0;i < len;i++)
	{
		html += '<li>' + data[i] + '</li>';
	}
	dom.parentNode.getElementsByTagName('span')[1].innerHTML = html;
}

var createValidataResult = function(data,dom)
{
	dom.parentNode.getElementsByTagName('span')[0].innerHTML = data;
}

dealData('username error','validate',document.getElementsByTagName("input")[0]);
dealData(123,'sug',document.getElementsByTagName("input")[1]);
dealData(['aqiyi','alibaba','aimanfan'],'sug',document.getElementsByTagName("input")[1]);
dealData({'iqy':'aqiyi','albb':'alibaba'},'sug',document.getElementsByTagName("input")[1]);