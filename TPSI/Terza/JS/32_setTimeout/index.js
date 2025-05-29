"use strict";

let _img = document.getElementById("imgCarta");
let _btnGioca = document.getElementById("btnGioca");
let _lblSomma = document.getElementById("lblSomma");
let _lblCarte = document.getElementById("lblCarte");
let _lblRisultato = document.getElementById("lblRisultato");
let carteEstratte = [];
let valore = 0;
let nCarte = 0;


_btnGioca.addEventListener("click", function()
{
	this.disabled = true;
	giracarta();
}
);

function giracarta()
{
	let n; 
	do
	{
		n = generaNumero(1,11);
	}while(carteEstratte.includes(n))
	carteEstratte.push(n);
	valore += n<=7 ? n : 0.5;
	_img.src = `./img/bg_d${n}.gif`;
	_lblSomma.textContent = valore;
	nCarte++;
	_lblCarte.textContent = nCarte;
	if(nCarte < 3)
	{
		setTimeout(giracarta, 1000)
	}
	else 
	{
		if(valore == 7.5)
		{
			_lblRisultato.textContent = "Hai vinto!"
			
		}
		else
		{
			_lblRisultato.textContent = "Hai perso!"

		}
	}
}

function generaNumero(min, max) {
	let rnd = Math.floor((max - min) * Math.random()) + min;
	return rnd;
}