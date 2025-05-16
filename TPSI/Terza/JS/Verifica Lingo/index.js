"use strict"

const DIM = 5;
const parole = ["Barca", "Fiore", "Gente", "Fuoco", "Fungo", "Opaco", "Prova", "Sasso", "Scusa", "Torta", "Vespa"];
const wrapper = document.getElementById("wrapper");
const textBox = document.getElementsByTagName("input")[0];
let parolaSegreta;
let rigaCorrente = 0;

//Creazione della griglia di gioco
for (let i = 0; i < DIM; i++) {
    for (let j = 0; j < DIM; j++) {
        let div = document.createElement("div");
        wrapper.appendChild(div);
        div.classList.add("cella");
        div.id = `div-${i}-${j}`;
    }
}

//Generazione parola da indovinare
parolaSegreta = parole[generaNumero(0, parole.length)].toLocaleUpperCase();

//Posizionamento nella prima posizione della lettera iniziale della parola segreta
document.getElementById("div-0-0").innerText = parolaSegreta[0];
textBox.focus();

function controlloLettera(event) {
    let char = event.key;

    //Controlla se l'utente invia
    if (char == "Enter") {
        controlloInvio();

        //Ritorno per non usare un else che a parer mio avrebbe solo sporcato il codice
        return;
    }

    //Controllo le dimensioni del testo e mi assicuro che l'utente possa cancellare
    //se non rientra nei campi del controllo va nell'if che controllo che il carattere sia giusto
    if (textBox.value.length > DIM - 1 && char != "Backspace") {
        alert("Hai inserito troppi caratteri");
        textBox.focus();
    }
    else {
        //se il carattere è tra a e z (minuscole) il programma cancella e scrive la lettera maiuscola
        if (!(char < 'a' || char > 'z')) {
            event.preventDefault();
            textBox.value += event.key.toUpperCase();
        }
        //altrimenti controlla che il carattere non sia compreso tra A e Z (maiuscole) e diverso da backspace. In tal caso cancella l'input
        else if ((char < 'A' || char > 'Z') && char != "Backspace") {
            event.preventDefault();
        }
    }

}

function controlloInvio() {
    //Controlla che siano stati inseriti tutti i caratteri
    if (textBox.value.length < DIM) {
        alert("Non hai inserito il numero di lettere necessario");
        textBox.focus();

        //Ritorno per non usare un else che a parer mio avrebbe solo sporcato il codice
        return;
    }

    let aux = ""; //Variabile di appoggio per controllare che non vengano contati doppioni
    for (let i = 0; i < DIM; i++) {
        //Controllo carattere per carattere per vedere quali son corretti
        if (textBox.value[i] == parolaSegreta[i]) {
            let div = document.getElementById(`div-${rigaCorrente}-${i}`);

            div.style.backgroundColor = "greenYellow";
            div.innerHTML = textBox.value[i];
        }
        //Se uno di essi non è corretto controllo se è presente nella parola segreta
        else if (parolaSegreta.includes(textBox.value[i]) && !aux.includes(textBox.value[i])) {
            let div = document.getElementById(`div-${rigaCorrente}-${i}`);

            div.style.backgroundColor = "yellow";
            div.innerText = textBox.value[i];

            aux += textBox.value[i];
        }
    }

    if(textBox.value == parolaSegreta)
    {
        alert("Hai vinto");
        textBox.disabled = true;
    }
    //Se la riga corrente supera le celle possibili hai perso a meno che tu non abbia vinto
    else if (rigaCorrente > DIM - 1) {
        alert("Hai perso");
        textBox.disabled = true;
    }

    rigaCorrente++;
    textBox.value = "";
    textBox.focus();
}


function generaNumero(a, b) {
    return Math.floor((b - a) * Math.random()) + a;
}

