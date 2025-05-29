"use strict";

window.onload = function () {

	//Assegnazione dei puntatori
	let _txtMatricola = document.getElementById("matricola");
	let _txtCognome = document.getElementById("cognome");
	let _txtNome = document.getElementById("nome");
	let _optGenere = document.getElementsByName("genere");
	let _lstRegione = document.getElementById("regione");
	let _chkLavoratore = document.getElementById("lavoratore");
	let _pDescrizione = document.getElementById("descrizione");
	let _txtDescrizione = _pDescrizione.querySelector("input");
	let _divMsg = document.getElementById("msg");
	let _btnInvia = document.querySelector("input[type=button]");

	//Associazione degli eventi
	_txtMatricola.addEventListener("change", controllaMatricola);
	_txtNome.addEventListener("change", controllaNomeCognome);
	_txtCognome.addEventListener("change", controllaNomeCognome);
	_chkLavoratore.addEventListener("change", nascondiTextBox);
	_btnInvia.addEventListener("click", validaForm);
	//Inizializzazioni
	_pDescrizione.style.display = "none";

	function validaForm()
	{
		let msg = "";
		if(!controllaMatricola())
		{
			msg += "Matricola non valida! <br>";
			
		}
		if(msg != "")
		{
			_divMsg.innerHTML = msg;
			_divMsg.style.color = "red";
		}
		else 
		{
			_divMsg.innerHTML = "";
			alert("Dati inviati correttamente!")
		}
	}

	function nascondiTextBox()
	{
		if(this.checked)
		{
			_pDescrizione.style.display = "block";
		}
		else 
		{
			_pDescrizione.style.display = "none";
		}
	}

	function controllaNomeCognome()
	{
		if (this.value.length < 4 || !isLetter(this.value)) 
		{
			//this.style.borderColor = "red";
			this.classList.add("red-border");
		}
		else 
		{
			//this.style.borderColor = "lightGreen";
			this.classList.remove("red-border");

		}
	}


	function controllaMatricola() 
	{
		if (_txtMatricola.value.length < 12 || !isDigit(_txtMatricola.value)) 
		{
			//_txtMatricola.style.borderColor = "red";
			_txtMatricola.classList.add("red-border");
			return false;
		}
		else 
		{
			//_txtMatricola.style.borderColor = "lightGreen";
			_txtMatricola.classList.remove("red-border");
			return true;

		}
	}

}








