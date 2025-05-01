"use strict"
const _radio = document.getElementsByName("radio");
const _txtRange = document.getElementById("txtRange");
const _btnGenera = document.getElementById("btnGenera");
const _password = document.getElementById("password");
const _spans = document.getElementsByTagName("span");
let lenght = 12;
let password = "";
let char = "";
let number = 0;
let esito = 0;

function genera() {
	if (_radio[0].checked == true) {
		for (let i = 0; i < _txtRange.value; i++) {
			esito = random(0, 2);
			if (esito == 0) {
				char = String.fromCharCode(random(65, 91));
				password += char;
			}
			else if (esito == 1) {
				char = String.fromCharCode(random(97, 123));
				password += char;
			}
		}
		esito = 0;
		char = "";
		_password.innerText = password;
	}
	else if (_radio[1].checked == true) {
		_password.innerText = "";
		for (let i = 0; i < _txtRange.value; i++) {
			number = random(1, 10);
			password += number;
		}

		number = 0;
		_password.innerText = password;
	}
	else if (_radio[2].checked == true) {
		_password.innerText = "";
		for (let i = 0; i < _txtRange.value; i++) {
			esito = random(0, 3);
			if (esito == 0) {
				char = String.fromCharCode(random(65, 91));
				password += char;
			}
			else if (esito == 1) {
				char = String.fromCharCode(random(97, 123));
				password += char;
			}
			else {
				number = random(1, 10);
				password += number;
			}
		}
		esito = 0;
		char = "";
		number = 0;
		_password.innerText = password;
	}
	else {
		_password.innerText = "";
		for (let i = 0; i < _txtRange.value; i++) {

			char = String.fromCharCode(random(47, 126));
			password += char;

		}
		char = "";
		number = 0;
		_password.innerText = password;
	}



}

function abilita() {
	_btnGenera.disabled = false;
}

function aggiorna() {
	_spans[0].textContent = `lunghezza: ${_txtRange.value}`;
}


function random(min, max) {
	return Math.floor((max - min) * Math.random() + min)
}



