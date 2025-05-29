"use strict"

const DIM = 4;

const wrapper = document.getElementById("wrapper");

creaMatrice()
creaNumero()
creaNumero()
elabora();

function elabora(event){
	switch(event.key){
	case "ArrowUp": document.addEventListener("keyUp", spostaSu()); break;
	case "ArrowDown": spostaGiu(); break
	case "ArrowLeft": spostaSinistra(); break;
	case "ArrowRight": spostaDestra(); break;
	}	
}

function spostaSu() {
	for (let i = 0; i < DIM; i++) {
		for (let j = 0; j < DIM; j++) {
			let div = document.getElementById(`${i}-${j}`);
			if (div.textContent == "2") {
				div.textContent = "";
				let div2 = document.getElementById(`${i-1}-${j}`);
				div2.textContent = "2";
			}
		}
	}	

}



function creaMatrice() {
	for (let i = 0; i < DIM; i++) {
		for (let j = 0; j < DIM; j++) {
			let div = document.createElement("div");
			div.classList.add("cella")
			div.id = `${i}-${j}`;
			wrapper.appendChild(div);
		}
	}

}

function creaNumero() {
	let i =generaNumero(0, 4);
	let j =generaNumero(0, 4);	
	let div;
	do
	{
		i =generaNumero(0, 4);
		j =generaNumero(0, 4);

		div = document.getElementById(`${i}-${j}`)
		div.textContent = "2";
	}while(!(div.id == `${i}-${j}`) && !(div.textContent == "2"))
		
}


function generaNumero(min, max) {
	return Math.floor((max - min) * Math.random()) + min;
}
