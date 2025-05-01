"use strict"

const DIM = 26;
let mat = [];
let aus = [];
const _div1 = document.getElementById("div1");
const _div2 = document.getElementById("div2");
const _txt1 = document.getElementById("txt1");
const _txt2 = document.getElementById("txt2")

mat[0] = new Array(DIM);
mat[1] = new Array(DIM);

caricaMatrice();

function caricaMatrice() 
{
	//Carica riga 0 in maniera sequenziale
	for (let i = 0; i < DIM; i++) {
		mat[0][i] = String.fromCharCode(65 + i);
		aus[i] = mat[0][i];
	}
	//Carica riga 1 della matrice casualmente
	for (let i = 0; i < DIM; i++) {
		console.log(aus);
		let pos = random(0, aus.length);
		mat[1][i] = aus[pos];
		aus.splice(pos, 1);
	}
	//Visualizza la matrice nei div
	for (let i = 0; i < DIM; i++) {
		_div1.textContent += mat[0][i] + " ";
		_div2.textContent += mat[1][i] + " ";

	}
}
//Funziona con onkeyup e oninput
function converti() 
{ 	
	_txt1.value = _txt1.value.toUpperCase();

}
function scrambler()
{
	for(let i = 0; i < _txt1.value.length;i++)
	{
		let char = _txt1.value[i];
		let pos = mat[0].indexOf(char);
		_txt2.value += mat[1][pos]; 
	}
}

function descrambler()
{
	let ris = "";
	for(let i = 0; i < _txt1.value.length;i++)
	{
		let char = _txt2.value[i];
		let pos = mat[1].indexOf(char);
		ris +=  mat[0][pos];
	}
	alert(`La stringa decodificata è ${ris}`);

}
function random(min, max) {
	return Math.floor((max - min) * Math.random() + min);
}