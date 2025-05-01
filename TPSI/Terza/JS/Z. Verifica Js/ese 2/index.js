"use strict";
const _divNazione = document.getElementById("nazione");
const _imgNazione = document.getElementById("bandiera");

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
	"Spagna", "Spagna"]

let elencoUnivocoNazioni = []
let index = 0;

init();



function init()
{
	let j = 0;
	for(let i = 0; i < nazioni.length;i++)
	{
		 index = random(1,8);
		if(nazioni[i] != nazioni[i+1])
		{
			
			elencoUnivocoNazioni[j] = nazioni[i];
			j++;
		}	
	}
	_divNazione.textContent = elencoUnivocoNazioni[index];
	let temp  = elencoUnivocoNazioni[index].toLowerCase();
	console.log(temp)
	_imgNazione.src = "./img/" + temp + ".png";

}









function random(min, max){
	return Math.floor((max-min)*Math.random()+min)
}
