"use strict"

const GIALLO = "rgb(255, 255, 0)"
const GRIGIO = "rgb(160, 160, 160)"

const _select = document.getElementsByTagName("select")[0];
const wrapper = document.getElementById("wrapper");
let dim = 0
for (let i = 3; i <= 6; i++) {
    let option = document.createElement("option");
    _select.appendChild(option);
    option.value = i;
    option.textContent = `${i}x${i}`;

}
_select.selectedIndex = -1;
_select.addEventListener("change", function () {
    dim = this.value;
    wrapper.style.width = `${parseInt(dim * 50)}px `;
    wrapper.innerHTML = "";
    for (let i = 0; i < dim; i++) {
        for (let j = 0; j < dim; j++) {
            let div = document.createElement("div");
            wrapper.appendChild(div);
            div.classList.add("pedina");
            div.style.backgroundColor = GRIGIO;
            div.id = `div-${i}-${j}`;
            div.addEventListener("click", cambiaColore);
        }
    }
}
);

function cambiaColore() {
    let row = parseInt(this.id.split("-")[1]);
    let col = parseInt(this.id.split("-")[2]);

    accendiSpegni(this)

    //Cella Superiore
    if (row > 0) {
        let div = document.getElementById(`div-${row-1}-${col}`);
        accendiSpegni(div);
    }
    //Cella di Sinistra
    if (col > 0) {
        let div = document.getElementById(`div-${row}-${col-1}`);
        accendiSpegni(div);
    }
    //Cella di Destra
    if (col < dim - 1) {
        let div = document.getElementById(`div-${row}-${col+1}`);
        accendiSpegni(div);
    }
    //Cella Inferiore
    if (row < dim - 1) {
        let div = document.getElementById(`div-${row+1}-${col}`);
        accendiSpegni(div);
    }
}

function accendiSpegni(div) {
    if (div.style.backgroundColor == GRIGIO) {
        div.style.backgroundColor = GIALLO;
        vittoria()
    }
    else {
        div.style.backgroundColor = GRIGIO;
    }
}

function vittoria() {
    for (let i = 0; i < dim; i++) {
        for (let j = 0; j < dim; j++) {
            let div = document.getElementById(`div-${i}-${j}`);
            if(div.style.backgroundColor == GRIGIO) {
                return;
            }
        }
    }
    alert("Hai vinto!");
    // Disabilito i click su tutte le celle dopo la vittoria
    for (let i = 0; i < dim; i++) {
        for (let j = 0; j < dim; j++) {
            let div = document.getElementById(`div-${i}-${j}`);
            div.removeEventListener("click", cambiaColore);
        }
    }
}