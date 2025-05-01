"use strict"
const _btnGenera = document.getElementById("btnGenera");
const _spans = document.getElementsByTagName("span");
const _txtRange = document.getElementById("txtRange");
const _radios = document.getElementsByName("radio");
function genera()
{
	let radioSelected;
	let passwordLenght;
	let password = "";
	
	for(let i = 0; i < _radios.length; i++)
	{
		if(_radios[i].checked)
		{
			radioSelected =  i;
		}
	}

	passwordLenght = parseInt(_txtRange.value);
	for(let i = 0; i < passwordLenght; i++)
	{
		let asciiCode = 0;
		switch (radioSelected)
		{
			case 0:
			{
				do
				{
					asciiCode = random(65,123);
				}
				while(!(asciiCode >= 65 && asciiCode <= 90 || asciiCode>= 97 && asciiCode <= 122))
				//while(asciiCode >= 91 && asciiCode <= 96)
				break;
			}
			case 1:
			{
				asciiCode = random(48,58);
				break;
			}
			case 2:
			{
				do
				{
					asciiCode = random(48,123);
				}
				while(!(asciiCode >= 65 && asciiCode <= 90 || asciiCode>= 97 && asciiCode <= 122 || asciiCode >= 48 && asciiCode <= 57))
				break;
			}
			case 3:
			{
				asciiCode = random(47,126);
				break;
			}
		}
		password += String.fromCharCode(asciiCode);
	}
	_spans[1].textContent = password;
}

function aggiorna(event)
{
	_spans[0].textContent = `Lunghezza: ${_txtRange.value}`;
	//_spans[0].textContent = `Lunghezza: ${event.target.value}`;
}

function abilita()
{
	_btnGenera.disabled = false;
}

function random(min, max){
	return Math.floor((max-min)*Math.random()+min)
}



