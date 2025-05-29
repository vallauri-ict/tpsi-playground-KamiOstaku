"use strict";

const RIGHE = 6;
const COLONNE = 7;

const GREY = "rgb(127, 127, 127)";
const YELLOW = "rgb(255, 255, 0)";
const RED = "rgb(255, 0, 0)";

const wrapper = document.getElementById("wrapper");
const _nextPlayer = document.getElementById("nextPlayer");

//function click()
//La variabile click contiene al suo interno un puntatore a funzione
//tuttavia se si usa questa sintassi la variabile click deve essere definita prima del suo utilizzo
let click = function () {
    let i = parseInt(this.id.split("-")[1]);
    let j = parseInt(this.id.split("-")[2]);

    if (i > 0) {
        let divSuperiore = document.getElementById(`div-${i - 1}-${j}`);
        divSuperiore.addEventListener("click", click);
    }

    this.style.backgroundColor = _nextPlayer.style.backgroundColor;
    this.removeEventListener("click", click);

    if (controllaVittoria(i, j)) {
        let color;
        if (_nextPlayer.style.backgroundColor == YELLOW) {
            color = "giallo"
        }
        else {
            color = "rosso"
        }
        alert(`il colore ${color} ha vinto`);
        disabilitaPulsanti();

    }
    else {
        aggiornaTurno();
    }

}

_nextPlayer.style.backgroundColor = YELLOW;
_nextPlayer.classList.add("pedina");

for (let i = 0; i < RIGHE; i++) {
    for (let j = 0; j < COLONNE; j++) {
        let div = document.createElement("div");
        div.classList.add("pedina");
        div.style.backgroundColor = GREY;
        div.id = `div-${i}-${j}`;
        wrapper.appendChild(div);
        if (i == RIGHE - 1) {
            div.addEventListener("click", click);
        }

    }
}

function controllaVittoria(row, col) {

    //Controllo orizzontale
    for (let j = 0; j <= COLONNE - 4; j++) 
    {
        let current = document.getElementById(`div-${row}-${j}`)

        if (current.style.backgroundColor != GREY) 
        {
            let next1 = document.getElementById(`div-${row}-${j + 1}`)
            let next2 = document.getElementById(`div-${row}-${j + 2}`)
            let next3 = document.getElementById(`div-${row}-${j + 3}`)

            if (current.style.backgroundColor == next1.style.backgroundColor &&
                current.style.backgroundColor == next2.style.backgroundColor &&
                current.style.backgroundColor == next3.style.backgroundColor

            ) 
            {
                return true
            }
        }
        
    }

    //Controllo Verticale
    for (let i = 0; i <= RIGHE - 4; i++) 
        {
            let current = document.getElementById(`div-${i}-${col}`)
    
            if (current.style.backgroundColor != GREY) 
            {
                let next1 = document.getElementById(`div-${i + 1}-${col}`)
                let next2 = document.getElementById(`div-${i + 2}-${col}`)
                let next3 = document.getElementById(`div-${i + 3}-${col}`)
    
                if (current.style.backgroundColor == next1.style.backgroundColor &&
                    current.style.backgroundColor == next2.style.backgroundColor &&
                    current.style.backgroundColor == next3.style.backgroundColor
    
                ) 
                {
                    return true
                }
            }
            
        }
        return false; 
}


function disabilitaPulsanti()
{
    let divs = wrapper.querySelectorAll("div");
    for(let div of divs)
    {
        div.removeEventListener("click", click)
    }
}

function aggiornaTurno() {
    if (_nextPlayer.style.backgroundColor == YELLOW) {
        _nextPlayer.style.backgroundColor = RED;
    }
    else {
        _nextPlayer.style.backgroundColor = YELLOW;
    }
}



