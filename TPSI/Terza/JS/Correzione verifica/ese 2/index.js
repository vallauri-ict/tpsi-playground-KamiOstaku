"use strict";

let citta=[
	"Londra", "Liverpool", "Manchester", "Cambridge",
	"Amsterdam", "Rotterdam", "Maastricht",
	"Lisbona", "Oporto", "Braga",
	"Stoccolma", "Goteborg",
	"Kiev", "Leopoli", "Odessa",
	"Berna", "Lugano", "Zurigo", 
	"Madrid", "Barcellona"
]

let nazioni=[
	"Inghilterra", "Inghilterra", "Inghilterra", "Inghilterra", 
	"Olanda", "Olanda", "Olanda",
	"Portogallo", "Portogallo", "Portogallo",
	"Svezia", "Svezia",
	"Ucraina", "Ucraina", "Ucraina",
	"Svizzera", "Svizzera", "Svizzera",
	"Spagna", "Spagna"];

let elencoUnivocoNazioni = [];
const _txtNazione = document.getElementById("nazione");
const _imgBandiera = document.getElementById("bandiera");
const _chksCitta = document.getElementsByName("chkCitta");
const _txtsCitta = document.getElementsByName("txtCitta");
//const _imgsCitta = document.getElementsByClassName("img");
const wrapper = document.getElementById("wrapper");
const divs = wrapper.getElementsByTagName("div");
const _imgsCitta = divs[1].getElementsByTagName("img");
let nazioneSegreta;
let contCitta = 0;
init();
visualizzaNazione();



for(let i = 0; i < nazioni.length;i++)
{
	if(nazioni[i] == nazioneSegreta)
	{
		contCitta++;
	}
}

for(let i = 0; i < _txtsCitta.length;i++)
{
	let pos = random(0, citta.length);
	_txtsCitta[i].value = citta[pos]; 
	_txtsCitta[i].nazione = nazioni[pos];
	citta.splice(pos,1);
	nazioni.splice(pos,1);
	
}




function controlla()
{
	let contCorrect = 0;
	let contChecked = 0;

	for(let i = 0; i < _chksCitta.length; i++)
	{
		if(_chksCitta[i].checked)
		{
			contChecked++;
			if(_txtsCitta[i].nazione == nazioneSegreta)
			{
				_chksCitta[i].disabled = true;
				_imgsCitta[i].src = `./img/${nazioneSegreta.toLowerCase()}.png`
				_txtsCitta[i].disabled = true;
				contCorrect++;
			}
		}
	}

	if(contCorrect == contCitta && contChecked == contCitta)
	{
		alert("Hai vinto!");
	}
	else 
	{
		alert("Riprova!");
	}
}



function visualizzaNazione()
{
	let index = random(0, elencoUnivocoNazioni.length);
	nazioneSegreta =  elencoUnivocoNazioni[index];
	_txtNazione.textContent = nazioneSegreta;
	_imgBandiera.src = `./img/${nazioneSegreta.toLowerCase()}.png`
}

function init()
{
	for(let i = 0; i < nazioni.length;i++)
	{
		if(!(elencoUnivocoNazioni.includes(nazioni[i])))
		{
			elencoUnivocoNazioni.push(nazioni[i]);
	
		}
	}
}









function random(min, max){
	return Math.floor((max-min)*Math.random()+min)
}
