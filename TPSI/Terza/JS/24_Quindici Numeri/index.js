"use strict"
const DIM = 4;
const wrapper = document.getElementById("wrapper");
let aus = [];

for (let i = 0; i < DIM; i++) {
    for (let j = 0; j < DIM; j++) {
        const div = document.createElement("div");
        wrapper.appendChild(div);
        div.classList.add("pedina");
        let n
        do {
            n = generaNumero(1, 17);
        } while (aus.includes(n))
        aus.push(n);
        if (n <= 15) {
            div.style.backgroundColor = "blue";
            div.textContent = n;
        }

        div.id = `div-${i}-${j}`;

        div.addEventListener("click", sposta);


    }
}

function sposta() {
    let row = parseInt(this.id.split("-")[1]);
    let col = parseInt(this.id.split("-")[2]);

    //Controllo cella superiore
    if (row > 0) {
        let div = document.getElementById(`div-${row - 1}-${col}`);
        if (div.textContent == "") {
            swap(this, div);
        }
    }
    //Controllo cella di sinistra
    if (col > 0) {
        let div = document.getElementById(`div-${row}-${col - 1}`);
        if (div.textContent == "") {
            swap(this, div);
        }
    }
    //Controllo cella di destra
    if (col < DIM - 1) {
        let div = document.getElementById(`div-${row}-${col + 1}`);
        if (div.textContent == "") {
            swap(this, div);
        }
    }
    //Controllo cella inferiore
    if (row < DIM - 1) {
        let div = document.getElementById(`div-${row + 1}-${col}`);
        if (div.textContent == "") {
            swap(this, div);
        }
    }
}

//Cella1 è la cella selezionata, cella2 è la cella libera
function swap(cella1, cella2) {
    cella2.textContent = cella1.textContent;
    cella2.style.backgroundColor = cella1.style.backgroundColor;
    cella1.textContent = "";
    cella1.style.backgroundColor = ""; //Togliendo il backgroundColor dinamico rimane il valore statico
    controllaVincita();
}

function controllaVincita() {
    let cont = 1;

    for (let i = 0; i < DIM; i++) {
        for (let j = 0; j < DIM; j++) {
            let div = document.getElementById(`div-${i}-${j}`);
            if (cont == parseInt(div.textContent)) {
                cont++;
                if (cont == 16) {
                    alert("Bravissimo hai vinto!!!");
                    reset();
                    return;
                }
            }
        }
    }
}

function reset() {
    for (let i = 0; i < DIM; i++) {
        for (let j = 0; j < DIM; j++) {
            let div = document.getElementById(`div-${i}-${j}`);
            div.removeEventListener("click", sposta)
        }
    }
}


function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}