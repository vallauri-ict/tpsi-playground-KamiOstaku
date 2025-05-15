"use strict"

const DIM = 4;

const wrapper = document.getElementById("wrapper");
const punteggio = document.getElementsByTagName("span")[0];
let freeCells = 16;

creaMatrice();
creaNumero(2);

function controlla(event) {
	switch (event.key) {
		case "ArrowUp":
			spostamentoAlto();
			break;

		case "ArrowDown":
			spostamentoBasso()
			break;

		case "ArrowRight":
			spostamentoDestra()
			break;

		case "ArrowLeft":
			spostamentoSinistra()
			break;
	}
}

function spostamentoAlto() {
	let sopra, sotto;
	for (let k = 0; k < 3; k++) {
		for (let i = 2; i >= 0; i--) {
			for (let j = 0; j < 4; j++) {
				sotto = document.getElementById(`${i + 1},${j}`);

				if (sotto.innerText != "") {
					sopra = document.getElementById(`${i},${j}`);

					if (sopra.innerText == sotto.innerText) {
						sopra.innerText = parseInt(sopra.innerText) + parseInt(sotto.innerText);
						punteggio.textContent = parseInt(punteggio.textContent) + parseInt(sopra.innerText);
						sotto.innerText = "";
						freeCells++;
					}
					else if (sopra.innerText == "") {
						sopra.innerText = sotto.innerText;
						sotto.innerText = "";
					}
				}
			}
		}
	}

	creaNumero(1);
}

function spostamentoBasso() {
	let sopra, sotto;
	for (let k = 0; k < 3; k++) {
		for (let i = 0; i < 3; i++) {
			for (let j = 0; j < 4; j++) {
				sopra = document.getElementById(`${i},${j}`);

				if (sopra.innerText != "") {
					sotto = document.getElementById(`${i + 1},${j}`);

					if (sopra.innerText == sotto.innerText) {
						sotto.innerText = parseInt(sopra.innerText) + parseInt(sotto.innerText);
						punteggio.textContent = parseInt(punteggio.textContent) + parseInt(sotto.innerText);
						sopra.innerText = "";
						freeCells++;
					}
					else if (sotto.innerText == "") {
						sotto.innerText = sopra.innerText;
						sopra.innerText = "";
					}
				}
			}
		}
	}
	creaNumero(1);
}

function spostamentoDestra() {
	let sopra, sotto;
	for (let k = 0; k < 3; k++) {
		for (let i = 0; i < 3; i++) {
			for (let j = 0; j < 4; j++) {
				sopra = document.getElementById(`${j},${i}`);

				if (sopra.innerText != "") {
					sotto = document.getElementById(`${j},${i + 1}`);

					if (sopra.innerText == sotto.innerText) {
						sotto.innerText = parseInt(sopra.innerText) + parseInt(sotto.innerText);
						punteggio.textContent = parseInt(punteggio.textContent) + parseInt(sotto.innerText);
						sopra.innerText = "";
						freeCells++;
					}
					else if (sotto.innerText == "") {
						sotto.innerText = sopra.innerText;
						sopra.innerText = "";
					}
				}
			}
		}
	}
	creaNumero(1);
}

function spostamentoSinistra() {
	let sopra, sotto;
	for (let k = 0; k < 3; k++) {
		for (let i = 0; i < 3; i++) {
			for (let j = 0; j < 4; j++) {
				sopra = document.getElementById(`${j},${i+1}`);

				if (sopra.innerText != "") {
					sotto = document.getElementById(`${j},${i}`);

					if (sopra.innerText == sotto.innerText) {
						sotto.innerText = parseInt(sopra.innerText) + parseInt(sotto.innerText);
						punteggio.textContent = parseInt(punteggio.textContent) + parseInt(sotto.innerText);
						sopra.innerText = "";
						freeCells++;
					}
					else if (sotto.innerText == "") {
						sotto.innerText = sopra.innerText;
						sopra.innerText = "";
					}
				}
			}
		}
	}
	creaNumero(1);
}

function creaNumero(value) {
	if (freeCells != 0) {
		let cont = 0;
		let div;

		do {
			div = document.getElementById(`${generaNumero(0, 4)},${generaNumero(0, 4)}`);

			if (div.innerText == "") {
				cont++;
				div.innerText = "2";
				freeCells--;
			}
		} while (cont < value);
	}
	else
	{
		alert("Hai perso");
	}
}

function creaMatrice() {
	for (let i = 0; i < 4; i++) {
		for (let j = 0; j < 4; j++) {
			let div = document.createElement("div");
			wrapper.appendChild(div);
			div.id = `${i},${j}`;
			div.classList.add("cella");
		}
	}
}

function generaNumero(min, max) {
	return Math.floor((max - min) * Math.random()) + min;
}
