"use strict"

// Dichiarazione variabili globali
let turno = true; // true=giocatore1, false=giocatore2
const RIGHE = 3;
const COLONNE = 3;
let cont = 0;

// Creazione tabella
let table = document.getElementsByTagName("table")[0];

// Funzione che crea la tabella
function creaTabella() {
    for(let i=0; i<RIGHE; i++) {
        let tr = document.createElement("tr");
        for(let j=0; j<COLONNE; j++) {
            let td = document.createElement("td");
            let img = document.createElement("img");
            img.src = "img/vuota.png";
            img.id = `img-${i}-${j}`;
            img.addEventListener("click", imgClick);
            td.appendChild(img);
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
}

function imgClick() {
    // Recupero ID immagine cliccata
    let aus = this.id.split("-");
    let r = aus[1];
    let c = aus[2];
    let img = document.getElementById(`img-${r}-${c}`);
    
    // Controllo se casella è libera
    if(img.src.includes("vuota.png")) {
        // Aggiorno immagine in base al turno
        img.src = turno ? "img/croce.png" : "img/cerchio.png";
        cont++;
        
        // Controllo vittoria
        controllaVittoria();
        
        // Cambio turno
        turno = !turno;
    }
}

function controllaVittoria() {
    // Controllo righe
    for(let i=0; i<RIGHE; i++) {
        if(checkTris(i,0, i,1, i,2)) {
            vittoria();
            return;
        }
    }
    
    // Controllo colonne  
    for(let i=0; i<COLONNE; i++) {
        if(checkTris(0,i, 1,i, 2,i)) {
            vittoria();
            return;
        }
    }
    
    // Controllo diagonali
    if(checkTris(0,0, 1,1, 2,2)) {
        vittoria();
        return;
    }
    if(checkTris(0,2, 1,1, 2,0)) {
        vittoria();
        return;
    }
    
    // Se nessuna vittoria e tabella piena, pareggio
    if(cont == 9) {
        document.getElementById("divRisultato").innerHTML = "Pareggio!";
    }
}

function checkTris(r1,c1, r2,c2, r3,c3) {
    let img1 = document.getElementById(`img-${r1}-${c1}`);
    let img2 = document.getElementById(`img-${r2}-${c2}`);
    let img3 = document.getElementById(`img-${r3}-${c3}`);
    
    return (img1.src == img2.src && img2.src == img3.src && !img1.src.includes("vuota.png"));
}

function vittoria() {
    // Messaggio vittoria
    let vincitore = turno ? "Giocatore 1" : "Giocatore 2";
    document.getElementById("divRisultato").innerHTML = `Ha vinto ${vincitore}!`;
    
    // Disabilito click su tutte le immagini
    let imgs = document.getElementsByTagName("img");
    for(let img of imgs) {
        img.removeEventListener("click", imgClick);
    }
}

// Chiamata diretta alla funzione che crea la tabella
creaTabella();
