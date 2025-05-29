"use strict"
const DIM = 10;
let wrapper = document.getElementById("wrapper")
let riga, colonna;
let timerId, cont = 0;

for (let i = 0; i < DIM; i++) {
    for (let j = 0; j < DIM; j++) {
        let div = document.createElement("div");
        div.classList.add("cella");
        div.id = `div-${i}-${j}`;
        wrapper.appendChild(div);
        div.addEventListener("click", function()
        {
            this.style.backgroundColor = this.style.backgroundColor == "blue"? "rgb(127, 127, 127)" : "blue";
        });
    }
}

generaBomba();

function generaBomba() {
    riga = generaNumero(0, DIM);
    colonna = generaNumero(0, DIM);
    let div = document.getElementById(`div-${riga}-${colonna}`);
    div.addEventListener("click",bomba);
    div.style.backgroundImage = "url('bomba.png')";
    timerId = setInterval(spostaBomba, 150);
}

function bomba()
{
    alert("hai perso down");
    clearInterval(timerId);
}

function spostaBomba() {
    let div = document.getElementById(`div-${riga}-${colonna}`);
    div.removeEventListener("click",bomba);
    div.style.backgroundImage = "";

    switch (generaNumero(0, 4)) {
        case 0:
            if (riga < DIM-1) {
                riga++;
            }
            div = document.getElementById(`div-${riga}-${colonna}`);
            if(div.style.backgroundColor == "blue")
            {
                riga--;
                cont++;
            }
            else if(riga < 0)
            {
                cont = 0;
            }
            break;

        case 1:
            if (colonna < DIM-1) {
                colonna++;
            }
            div = document.getElementById(`div-${riga}-${colonna}`);
            if(div.style.backgroundColor == "blue")
            {
                colonna--;
                cont++;
            }
            else if(colonna > DIM-1)
            {
                cont = 0;
            }
        case 2:
            if (riga > 0) {
                riga--;
            }
            div = document.getElementById(`div-${riga}-${colonna}`);
            if(div.style.backgroundColor == "blue")
            {
                riga++;
                cont++;
            }
            else if(riga > DIM-1)
            {
                cont = 0;
            }
            break;

        case 3:
            if (colonna > 0) {
                colonna--;
            }
            div = document.getElementById(`div-${riga}-${colonna}`);
            if(div.style.backgroundColor == "blue")
            {
                colonna++;
                cont++;
            }
            else if(colonna < DIM-1)
            {
                cont = 0;
            }
            break;
    }

    div = document.getElementById(`div-${riga}-${colonna}`);
    div.addEventListener("click",bomba);
    div.style.backgroundImage = "url('bomba.png')";

    if(cont == 15)
    {
        alert("hai vinto");
        clearInterval(timerId);
    }
}

function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}
