"use strict";

const _div1 = document.getElementById("div1");
const _div2 = document.getElementById("div2");

const _div1txtCitta = _div1.getElementsByClassName("txt");
const _div1optCitta = document.getElementsByName("optCitta");

const _div2optNazioni = document.getElementsByName("optNazioni");
const _div2txtNazioni = _div2.getElementsByClassName("txt");
const _div2txtRisposte = document.getElementsByName("txtRisposte");

const _btnSeleziona = document.getElementById("btnSeleziona");
const _btnRisposta = document.getElementById("btnRisposta");

let randomPos;

let nChkRimasti = _div1optCitta.length - 1;

randomizzaNazioniInDiv2NazioniTxt();

function randomizzaNazioniInDiv2NazioniTxt(){
	let randomPosNazione;
	for(let i=0; i<_div1optCitta.length; i++){
		do{
			randomPosNazione = random(0, _div2txtNazioni.length);
		} while(_div2txtNazioni[randomPosNazione].getAttribute("nazione") != undefined);
		_div2txtNazioni[randomPosNazione].setAttribute("nazione", _div1txtCitta[i].getAttribute("nazione"));
		_div2txtNazioni[randomPosNazione].setAttribute("value", _div1txtCitta[i].getAttribute("nazione"));
	}
}

function seleziona(){
	do{
		randomPos = random(0, _div1optCitta.length);
	} while(_div1optCitta[randomPos].disabled);
	_div1optCitta[randomPos].checked = true;
}

function controlla(){

	let radioButtonNazioniChecked;

	// CONTROLLI PER IL CHECKED DEI RADIO BUTTON
	let divchecked = false
	for(let i=0; i<_div1optCitta.length; i++){
		if(_div1optCitta[i].checked){
			divchecked = true;
		}
	}
	if(!divchecked){
		alert("SELEZIONA UN CITTA A SINISTRA");
		return;
	}
	divchecked = false;
	for(let i=0; i<_div2optNazioni.length; i++){
		if(_div2optNazioni[i].checked){
			divchecked = true;
			radioButtonNazioniChecked = i;
		}
	}
	if(!divchecked){
		alert("SELEZIONA UN NAZIONE A DESTRA");
		return;
	}

	if(_div1txtCitta[randomPos].getAttribute("nazione") == _div2txtNazioni[radioButtonNazioniChecked].getAttribute("nazione")){

		_div2txtRisposte[radioButtonNazioniChecked].setAttribute("value", _div1txtCitta[randomPos].getAttribute("value"));

		alert("GIUSTO, Nazione citta: " + _div1txtCitta[randomPos].getAttribute("nazione") + ", Nazione selezionata: " + _div2txtNazioni[radioButtonNazioniChecked].getAttribute("nazione"))

		_div1optCitta[randomPos].disabled = true;
		_div1optCitta[randomPos].checked = false;
		_div2optNazioni[radioButtonNazioniChecked].disabled = true;
		_div1txtCitta[randomPos].value = "";
		_div1txtCitta[randomPos].disabled = true;
		_div2txtNazioni[radioButtonNazioniChecked].disabled = true;
		_div2txtRisposte[radioButtonNazioniChecked].disabled = true;

		nChkRimasti--;

		if(nChkRimasti == -1){
			alert("HAI VINTO!!!");
			_btnRisposta.disabled = true;
			_btnSeleziona.disabled = true;
		}
	} else {
		alert("RISPOSTA SBAGLIATA");
	}
}

function random(min,max){
	return Math.floor((max-min)*Math.random()+min);
}