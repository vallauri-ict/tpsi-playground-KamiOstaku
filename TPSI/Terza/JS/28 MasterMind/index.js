"use strict"
const ROSSO = "rgb(255, 0, 0)"
const GIALLO = "rgb(255, 255, 0)"
const VERDE = "rgb(0, 220, 0)"
const BLU = "rgb(0, 0, 220)"
const CIANO = "rgb(0, 255, 255)"
const VIOLA = "rgb(135, 38, 165)"

const GRIGIO = "rgb(235, 235, 235)"
const NERO = "rgb(0, 0, 0)"
const GRIGIO_SCURO = "rgb(110, 110, 110)"

let numSegreti = new Array(4);
let numUtente = new Array(4);

for(let i = 0; i < numSegreti.length;i++)
{
	numSegreti[i] = generaNumero(1,7);
	numUtente[i] = 1;
}

let rigaCorrente = 0;

const tabella = document.getElementsByTagName("table")[0];
generaCampoDaGioco();

function generaCampoDaGioco()
{
	let tr = document.createElement("tr");
	tabella.appendChild(tr);

	let td = document.createElement("td");
	tr.appendChild(td);
	td.innerText = (1+rigaCorrente);

	td = document.createElement("td");
	tr.appendChild(td);
	for(let i = 0; i < 4;i++)
	{
		let div = document.createElement("div");
		div.classList.add("pedina");
		div.colore = 1;
		div.style.backgroundColor = ROSSO;
		div.addEventListener("click",click);
		td.appendChild(div);
		div.id = `div-${rigaCorrente}-${i}`;
	}

	let btn = document.createElement("button");
	td.appendChild(btn);
	btn.addEventListener("click",controlloColori);
	btn.innerText = "invia";

	td = document.createElement("td");
	tr.appendChild(td);
	for(let i = 0; i < 4;i++)
	{
		let div = document.createElement("div");
		div.classList.add("pedina");
		div.style.backgroundColor = GRIGIO;
		td.appendChild(div);
		div.id = `ris-${rigaCorrente}-${i}`;
	}
}

function click()
{
	this.colore++;

	if(this.colore > 6)
	{
		this.colore = 1;
	}

	numUtente[this.id.split('-')[2]] = this.colore;
	this.style.backgroundColor = assegnaColore(this.colore);
}

function controlloColori()
{
	let haiVinto = true;
	for(let i = 0; i < 4; i++)
	{
		document.getElementById(`div-${rigaCorrente}-${i}`).removeEventListener("click",click);

		if(numUtente[i] == numSegreti[i])
		{
			document.getElementById(`ris-${rigaCorrente}-${i}`).style.backgroundColor = NERO;
		}
		else
		{
			haiVinto = false;
		}
	}

	if(!haiVinto)
	{
		rigaCorrente++;

		this.remove();
		generaCampoDaGioco();
		for(let i = 0; i < 4;i++)
		{
			numUtente[i] = 1;
		}
	}
	else
	{
		alert("Hai vinto");
	}
	
}

function assegnaColore(n){
	let colore = ""
	switch (n){
		case 1: colore=ROSSO; break;
		case 2: colore=GIALLO; break;
		case 3: colore=VERDE; break;
		case 4: colore=BLU; break;
		case 5: colore=CIANO; break;
		case 6: colore=VIOLA; break;
	}
	return colore;
}

function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}
