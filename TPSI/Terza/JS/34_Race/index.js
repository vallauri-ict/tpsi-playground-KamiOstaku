'use strict'

const COLONNE = 30;
const RIGHE = 20;
const OSTACOLI = 25;
const wrapper = document.getElementById("wrapper");
const btnAvvia = document.getElementById("btnAvvia");

let riga1, riga2;
let colonna1 = 0, colonna2 = 0;

init();
generaBombe();
let timerID;
let avanzamento = function () {
    let n1 = generaNumero(1, 11);
    let n2 = generaNumero(1, 11);

    if (n1 <= 7) {

        let btnNext = document.getElementById(`btn-${riga1}-${colonna1+1}`)

        if(btnNext.style.backgroundImage != "")
        {
            riga1++;
        }
        else 
        {
            colonna1++;
           
        }
        disegnaCella(riga1, colonna1);
        
    }

    if (n2 <= 7) {
        
        let btnNext = document.getElementById(`btn-${riga2}-${colonna2+1}`)

        if(btnNext.style.backgroundImage != "")
        {
            riga2++;
        }
        else 
        {
            colonna2++;
           
        }
        disegnaCella(riga2, colonna2);
    }

};

function disegnaCella(riga, colonna)
{
    let btn = document.getElementById(`btn-${riga}-${colonna}`)
    btn.style.backgroundColor = "blue"
    if (colonna == COLONNE - 1) {
        clearInterval(timerID);
        alert("Hai vinto!")
    }
}


btnAvvia.addEventListener("click", function () {
    do {
        riga1 = generaNumero(0, RIGHE - 5);
        riga2 = generaNumero(0, RIGHE - 5);
    } while (Math.abs(riga1 - riga2) < 4);
    let btn1 = document.getElementById(`btn-${riga1}-${colonna1}`);
    let btn2 = document.getElementById(`btn-${riga2}-${colonna2}`);
    btn1.style.backgroundColor = "blue";
    btn2.style.backgroundColor = "blue";
    this.disabled = true;
    timerID = setInterval(avanzamento, 150);

});

function init() {
    for (let i = 0; i < RIGHE; i++) {
        for (let j = 0; j < COLONNE; j++) {
            let btn = document.createElement("button");
            btn.id = `btn-${i}-${j}`;
            btn.classList.add("cella");
            btn.disabled = true;
            wrapper.appendChild(btn);
        }
    }

}

function generaBombe() {
    for (let n = 0; n < OSTACOLI; n++) {
        let i, j, btn;
        do {
            i = generaNumero(0, RIGHE);
            j = generaNumero(1, COLONNE);
            btn = document.getElementById(`btn-${i}-${j}`);


        } while (btn.style.backgroundImage != "");
        //Gli apici singoli sono obbligatori solo se nel nome del file ci sono degli spazi
        btn.style.backgroundImage = "url('bomba.png')";
    }
}


function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}
