"use strict";

let nomi =
	["Italia", "Lavagna", "Pizzeria", "Lasagne", "Spiedino", "Ananas", "Gnocchi",
     "Gorgonzola", "Broccoli", "Mango", "Biscotti", "Cenere", "Carabina", 
	 "Affettati", "Papera", "Affaticato", "Effervescente", "Ambulante", 
	 "Ambulanza", "Ostetricia"];
let pos = generaNumero(0, nomi.length);
let parolaSegreta = nomi[pos];
parolaSegreta = parolaSegreta.toUpperCase();
const _chks = document.getElementsByName("chkRis");
const _txts = document.getElementsByName("txtCar");
const _btnRisposta = document.getElementById("btnRisposta");
const _btnInvia = document.getElementById("btnInvia");
const _txtPunti = document.getElementById("txtPunti");
const _txtIns = document.getElementById("txtIns");

init();



function init()
{
	for(let i = 0; i < _txts.length; i++)
	{
		_txts[i].readOnly = true;
		_chks[i].checked = false;
		_chks[i].disabled = true;
	}
	console.log(parolaSegreta);
	for(let i = 0; i < parolaSegreta.length;i++)
	{
		_txts[i].value = "*";
	}
	
	for(let i = parolaSegreta.length; i < _txts.length;i++)
	{
		_txts[i].disabled = true;
	}
	_btnRisposta.disabled = false;
	_txtPunti.value = 100;
}

function abilitaBtnInvia()
{
	if(_txtIns.value == "")
	{
		_btnInvia.disabled = true;
	}
	else 
	{
		_btnInvia.disabled = false;
		_txtIns.value = _txtIns.value.toUpperCase();
	}
}

function confronta()
{
	const lettera = _txtIns.value;
	_txtPunti.value = parseInt(_txtPunti.value) - 5 ;
	for(let i = 0; i < parolaSegreta.length;i++)
	{
		if(lettera == parolaSegreta[i])
		{
			_txts[i].value = lettera;
			_chks[i].checked = true; 
		}
	}
	if(_txtPunti.value == 0)
	{
		alert("Hai perso!");
		_btnInvia.disabled = true;
		return;
	}
}

function rispondi()
{
	alert("$la parola segreta è {}")
}

function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}