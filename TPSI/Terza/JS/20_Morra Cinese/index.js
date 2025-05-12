"use strict";

let vet = ["mano", "sasso", "forbice"];
let imgUtente = "";

window.onload = function () {
    let _imgUtente = document.getElementById("imgUtente");
    let _imgComputer = document.getElementById("imgComputer");
    let _small = document.getElementsByClassName("small");
    let _btnGioca = document.getElementById("btnGioca");
    let _txtRisultato = document.getElementById("txtRisultato");

    // Imposta stili per la visualizzazione delle immagini
    impostaStileImmagine(_imgUtente);
    impostaStileImmagine(_imgComputer);
    for (let small of _small) {
        impostaStileImmagine(small);
    }

    // Inizializzazione immagini
    _imgComputer.style.backgroundImage = "url('img/vuoto.png')";
    _imgUtente.style.backgroundImage = "url('img/vuoto.png')";

    // Caricamento miniature
    for (let i = 0; i < _small.length; i++) {
        _small[i].style.backgroundImage = "url('img/" + vet[i] + ".png')";
        _small[i].addEventListener("click", function () {
            imgUtente = vet[i];
            _imgUtente.style.backgroundImage = this.style.backgroundImage;
            _imgComputer.style.backgroundImage = "url('img/vuoto.png')";
            _txtRisultato.innerHTML = "";
        });
    }

    // Gestione click pulsante Gioca
    _btnGioca.addEventListener("click", function () {
        if (imgUtente == "") {
            alert("Seleziona prima una carta!");
            return;
        }

        // Genera mossa computer
        let mossaComputer = vet[random(0, 3)];

        // Visualizza mossa computer
        _imgComputer.style.backgroundImage = "url('img/" + mossaComputer + ".png')";

        // Determina il vincitore
        let risultato = determinaVincitore(imgUtente, mossaComputer);
        _txtRisultato.innerHTML = risultato;
    });

}

function determinaVincitore(sceltaUtente, sceltaComputer) {
    if (sceltaUtente == "forbice" && sceltaComputer == "mano") 
        return "Hai vinto!";
    if (sceltaUtente == "mano" && sceltaComputer == "sasso") 
        return "Hai vinto!";
    if (sceltaUtente == "sasso" && sceltaComputer == "forbice") 
        return "Hai vinto!";

    if (sceltaComputer == "forbice" && sceltaUtente == "mano") 
        return "Ha vinto il computer!";
    if (sceltaComputer == "mano" && sceltaUtente == "sasso") 
        return "Ha vinto il computer!";
    if (sceltaComputer == "sasso" && sceltaUtente == "forbice") 
        return "Ha vinto il computer!";

    return "Pareggio!";
}

function random(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}

function impostaStileImmagine(elemento) {
    elemento.style.backgroundRepeat = "no-repeat";
    elemento.style.backgroundPosition = "center";
    elemento.style.backgroundSize = "contain";
}