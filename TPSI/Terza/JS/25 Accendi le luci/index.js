"use strict"

const GIALLO = "rgb(255, 255, 0)"
const GRIGIO = "rgb(160, 160, 160)"
<<<<<<< HEAD
const cmb = document.getElementsByTagName("select")[0];
const wrapper = document.getElementById("wrapper");

for(let i = 3; i < 7; i++)
{
    let option = document.createElement("option");
    option.value = i;
    option.textContent = `${i}x${i}`
    cmb.appendChild(option);
}

cmb.selectedIndex = -1;
cmb.addEventListener("change",function() 
{
    let dim = this.value;

    wrapper.style.width = `${dim*50}px`;
    wrapper.innerHTML = null;
    for(let i = 0; i < dim;i++)
    {
        for(let j = 0; j < dim;j++)
        {
            let div = document.createElement("div");
            wrapper.appendChild(div);

            div.classList.add("pedina");
            div.style.backgroundColor = GRIGIO;
            div.id = `${i},${j}`;
            div.addEventListener("click",cambiaColore);
        }
    }
});

function cambiaColore()
{
    const row = parseInt(this.id.split(",")[0]);
    const col = parseInt(this.id.split(",")[1]);

    accendiLucix(this.style.backgroundColor);

    if(row > 0)
    {
        let div = document.getElementById(`${row},${col}`);
    }
}

function accendiLucix(color)
{
    return color == GRIGIO? GIALLO : GRIGIO;
}

=======

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
        accendiSpegni(div);
    }
    //Cella di Sinistra
    if (col > 0) {
        let div = document.getElementById(`div-${row}-${col - 1}`);
        accendiSpegni(div);
    }
    //Cella di Destra
    if (col < dim - 1) {
        let div = document.getElementById(`div-${row}-${col + 1}`);
        accendiSpegni(div);
    }
    //Cella Inferiore
    if (row < dim - 1) {
        let div = document.getElementById(`div-${row + 1}-${col}`);
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
    let div = document.getElementById(`div-${row}-${col}`);
    for (let i = 0; i < dim; i++) {
        for (let j = 0; j < dim; j++) {
            if()
        }
    }
}
>>>>>>> b212a1ee77f869da5c768d83eb18842139192ab7
